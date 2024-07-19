import React, { useState, useEffect } from 'react';
import { ScrollView, Text, View, TouchableOpacity, ActivityIndicator, Alert } from 'react-native';
import { Link, router, useLocalSearchParams } from 'expo-router';
import { useQuery, useMutation, useQueryClient } from 'react-query';
import PrimaryButton from '@/components/primarybutton';
import MicroCard from '@/components/microCard';
import projectPageStyles from '@/styles/pages/projectPageStyles';
import { getProject, getSynergiesByProjectId, getProjectRating, postProjectRating } from '@/services/coreApi';
import Colors from '@/constants/colors';
import microCardStyles from '@/styles/microCardStyles';
import { Ionicons } from '@expo/vector-icons';
import { useAuth } from '@/hooks/auth.context';

// Define the interfaces of what is expected
interface Project {
    id: number;
    name: string;
    shortDescription: string;
    description: string;
    status: string;
    user: string;
    enterprise: string;
    microtheme: string;
    macrotheme: string;
}

interface Synergy {
    id: number;
    projectId: number;
    projectName: string;
    userEnterprise: string;
    userName: string;
    macrotheme: string;
    microtheme: string;
}

interface Rating {
    id: number;
    rating: number;
}

// Main puction of the project page
export default function ProjectPage() {
    // Define the userId and the projectId (from context and url)
    const { user } = useAuth();
    const { id: projectId } = useLocalSearchParams();

    // Project data
    const {
        data: project,
        error: projectError,
        isLoading: isProjectLoading
    } = useQuery<Project>(
        ['project', projectId],
        () => getProject(Number(projectId)),
        { enabled: !!projectId }
    );

    // Synergy data
    const {
        data: synergies,
        error: synergiesError,
        isLoading: isSynergiesLoading
    } = useQuery<Synergy[]>(
        ['synergies', projectId],
        () => getSynergiesByProjectId(Number(projectId)),
        { enabled: !!projectId }
    );

    // Rating Data
    const {
        data: ratingData,
        error: ratingError,
        isLoading: isRatingLoading
    } = useQuery<Rating>(
        ['ratingData', projectId, user],
        () => getProjectRating(Number(projectId), user!),
        { enabled: !!projectId && user !== null }
    );

    // Post rating: use the userId, projectId and rating params
    const queryClient = useQueryClient();
    const { mutate: postRatingMutation } = useMutation(
        ({ rating, userId }: { rating: number; userId: number }) =>
            postProjectRating(Number(projectId), { userId, rating }),
        {
            onSuccess: () => {
                console.log('Success: Avaliação enviada com sucesso.');
                Alert.alert('Successo', 'Sua avaliação foi submetida com sucesso.');
                queryClient.invalidateQueries(['ratingData', projectId]);
            },
            onError: (error) => {
                console.error('Error: Não foi possível enviar a avaliação.', error);
                Alert.alert('Erro', 'Não foi possível enviar sua avaliação. Tente novamente.');
            }
        }
    );

    // Define 5 icons and set rating as number
    const [rating, setRating] = useState<number>(ratingData?.rating || 0);
    const maxCircles = 5;

    // Handle the logic about witch icons matches witch number
    const handleRatingClick = (index: number) => {
        const newRating = index + 1;
        
        if (user) {
            setRating(newRating);
            postRatingMutation({ rating: newRating, userId: user });
        } else {
            console.error('User ID is null, cannot submit rating.');
            Alert.alert('Erro', 'Usuário não autenticado. Não é possível enviar a avaliação.');
        }
    };

    // Defines icon size
    const getCircleSize = (index: number) => {
        return 25 + (index * 6);
    };

    // Get the rated data
    useEffect(() => {
        if (ratingData) {
            setRating(ratingData.rating);
        }
    }, [ratingData]);

    // If the data is loading, show the loading icon
    if (isProjectLoading || isSynergiesLoading || isRatingLoading) {
        return (
            <ScrollView style={projectPageStyles.container}>
                <ActivityIndicator size="large" color={Colors.green400} />
            </ScrollView>
        );
    }

    // If there is an error, show the error message
    if (projectError || synergiesError || ratingError) {
        console.error('Error ao carregar os dados do projeto ou sinergias.', {
            projectError,
            synergiesError,
            ratingError
        });
        if (!ratingData) {
            console.warn('Rating data not found for this project.');
        } else {
            return (
                <ScrollView style={projectPageStyles.container}>
                    <Text style={projectPageStyles.text}>Erro ao carregar os dados.</Text>
                </ScrollView>
            );
        }
    }

    // If there is no project, show the error message
    if (!project) {
        return (
            <ScrollView style={projectPageStyles.container}>
                <Text style={projectPageStyles.text}>Projeto não encontrado.</Text>
            </ScrollView>
        );
    }

    // Return informations about the project, synergies and rating
    return (
        <View style={{ flex: 1 }}>
            <ScrollView style={projectPageStyles.container}>
                <Text style={projectPageStyles.title}>{project.name}</Text>
                <Text style={projectPageStyles.macrotheme}>{project.macrotheme}</Text>
                <Text style={projectPageStyles.company}>{project.enterprise}</Text>
                <Text style={projectPageStyles.user}>{project.user}</Text>
                <Text style={projectPageStyles.shortDescription}>{project.shortDescription}</Text>
                <Text style={projectPageStyles.description}>{project.description}</Text>

                {synergies && synergies.length > 0 ? (
                    <Text style={projectPageStyles.text}>Em sinergia com</Text>
                ) : (
                    <Text style={projectPageStyles.text}>Esse projeto ainda não possui sinergias</Text>
                )}

                <ScrollView
                    horizontal={true}
                    contentContainerStyle={projectPageStyles.synergiesContainer}
                    showsHorizontalScrollIndicator={false}
                >
                    {synergies && synergies.map((synergy) => (

                        <View key={synergy.id} style={microCardStyles.cardContainer}>
                            <Link href={`/synergies/${synergy.id}`} style={projectPageStyles.link}>

                                <MicroCard
                                    title={synergy.projectName}
                                    enterprise={synergy.userEnterprise}
                                    user={synergy.userName}
                                    macrotheme={synergy.macrotheme}
                                    microtheme={synergy.microtheme}
                                    isSelected={false}
                                />
                            </Link>
                        </View>
                    ))}
                </ScrollView>
            </ScrollView>

            <View style={{ position: 'absolute', bottom: 0, left: 0, right: 0, margin: 10 }}>
                <PrimaryButton
                    text="Criar Sinergia"
                    onPress={() => {
                        router.push({
                            pathname: '/synergies/firstForm',
                            params: { sourceProject: project.id },
                        });
                    }}
                />

                <View style={projectPageStyles.ratingContainer}>
                    <Text style={projectPageStyles.ratingTitle}>
                        Avalie o seu nível de{'\n'}
                        interesse no projeto
                    </Text>
                    <View style={projectPageStyles.circleContainer}>
                        {Array.from({ length: maxCircles }, (_, index) => (
                            <TouchableOpacity key={index} onPress={() => handleRatingClick(index)}>
                                <Ionicons
                                    name="ellipse"
                                    size={getCircleSize(index)}
                                    color={rating > index ? Colors.rating : Colors.neutral400}
                                    style={projectPageStyles.icon}
                                />
                            </TouchableOpacity>
                        ))}
                    </View>
                </View>
            </View>
        </View>
    );
}
