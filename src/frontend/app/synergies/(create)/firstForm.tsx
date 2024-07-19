import React, { useState, useEffect, useCallback } from 'react';
import { View, Text, ScrollView, TouchableOpacity, ActivityIndicator } from 'react-native';
import { useForm, Controller, SubmitHandler } from 'react-hook-form';
import { useRouter, useLocalSearchParams } from 'expo-router';
import { useQuery } from 'react-query';
import PrimaryButton from '@/components/primarybutton';
import Microcard from '@/components/microCard';
import firstFormStyles from '@/styles/pages/createSynergy/firstFormStyles';
import useStyles from '@/styles/useStyles';
import { getProjectsByUserId } from '@/services/coreApi';
import { Colors } from 'react-native/Libraries/NewAppScreen';
import { useAuth } from '@/hooks/auth.context';

type FormData = {
  selectedProjects: string[];
  sourceProject: string;
};

type Project = {
  id: string;
  name: string;
  enterprise: string;
  user: string;
  macrotheme: string;
  microtheme: string;
};


export default function FirstFormScreen() {
  const { user } = useAuth();

  const { control, handleSubmit, setValue } = useForm<FormData>({
    defaultValues: {
      selectedProjects: [],
      sourceProject: '',
    },
  });

  const router = useRouter();
  const styles = firstFormStyles;
  const globalStyles = useStyles();
  const { sourceProject } = useLocalSearchParams<{ sourceProject: string }>(); 

  // Use useQuery to search projects
  const { data: projects, error, isLoading } = useQuery(
    ['projects', user],
    () => getProjectsByUserId(Number(user)),
  );

  useEffect(() => {
    if (typeof sourceProject === 'string') {
      setValue('sourceProject', sourceProject);
    }
  }, [setValue, sourceProject]);  

  const onSubmit: SubmitHandler<FormData> = data => {
    const { selectedProjects, sourceProject } = data; 
    const updatedSelectedProjects = [...selectedProjects, sourceProject];
    const updatedFormData = { ...data, selectedProjects: updatedSelectedProjects };
    router.push({
      pathname: '/synergies/secondForm',
      params: { formData: JSON.stringify(updatedFormData) },
    });
  };

  const [selectedProject, setSelectedProject] = useState<string>('');

  const handleSelectProject = useCallback(
    (projectId: string) => {
      setSelectedProject(projectId);
      setValue("selectedProjects", [projectId]); // Select only one project
    },
    [setValue]
  );

  if (isLoading) {
    return(
      <View style={globalStyles.container}>
        <ActivityIndicator size="large" color={Colors.green400} />
      </View>
    );
  }

  if (error) {
    return <Text>Error fetching projects</Text>;
  }

  return (
    <View style={styles.wrapper}>
      <ScrollView contentContainerStyle={styles.contentContainer}>
        {/* Header text */}
        <Text style={styles.header}>Cadastro de Sinergia</Text>
        <Text style={styles.subheader}>
          Selecione qual dos seus projetos será usado para formar sinergia
        </Text>
  
        {/* Project selection */}
        <View style={styles.cardsContainer}>
          {isLoading ? (
            <Text>Loading...</Text>
          ) : (
            error ? (
              <Text>Error fetching projects</Text>
            ) : (
              projects?.map((project: Project) => (
                <TouchableOpacity
                  key={project.id}
                  onPress={() => handleSelectProject(project.id)}
                  style={styles.card}
                >
                  <Microcard
                    title={project.name}
                    enterprise={project.enterprise}
                    user={project.user}
                    macrotheme={project.macrotheme}
                    microtheme={project.microtheme}
                    isSelected={selectedProject === project.id}
                  />
                </TouchableOpacity>          
              ))
            )
          )}
        </View>
  
        {/* Controller to sync selectedProjects with form state */}
        <Controller
          control={control}
          name="selectedProjects"
          render={() => <></>}
        />
      </ScrollView>
  
      {/* Submit button */}
      <View style={styles.buttonContainer}>
        <PrimaryButton text="Continuar" onPress={handleSubmit(onSubmit)} />
      </View>
    </View>
  );
}