import React, { useState } from 'react';
import { View, Text, TextInput, ScrollView, ActivityIndicator, Alert } from 'react-native';
import { useForm, Controller, SubmitHandler } from 'react-hook-form';
import { useRouter, useLocalSearchParams } from 'expo-router';
import PrimaryButton from '@/components/primarybutton';
import secondFormStyles from '@/styles/pages/createProject/secondFormStyles';
import SecondaryButton from '@/components/secondaryButton';
import { useMutation, useQuery } from 'react-query';
import { generateDescription, createProject } from '@/services/coreApi';
import { useAuth } from '@/hooks/auth.context';
import Colors from '@/constants/colors';

// Define the form data types for both initial and second forms
type InitialFormData = {
  projectName: string;
  macrotheme: string;
  microtheme: string;
  shortDescription: string;
};

type SecondFormData = {
  description: string;
};

export default function SecondFormScreen() {
  // Get the user from the auth context
  const { user } = useAuth();

  // Initialize the form control using react-hook-form
  const { control, handleSubmit, setValue, getValues, formState: { errors } } = useForm<SecondFormData>({
    defaultValues: {
      description: '',
    },
  });

  // Get styles from external stylesheet
  const styles = secondFormStyles;

  // Get the router instance for navigation
  const router = useRouter();

  // Get the initial form data from the local search params
  const { formData } = useLocalSearchParams();
  const initialFormData: InitialFormData = formData ? JSON.parse(formData as string) : {};

  // Define the form submission handler
  const { mutate: createProjectMutation } = useMutation(createProject, {
    onSuccess: () => {
      router.push('/profile');
    },
    onError: () => {
      Alert.alert('Erro', 'Não foi possível criar o projeto. Tente novamente.');
    },
  });

  const onSubmit: SubmitHandler<SecondFormData> = data => {
    const completeFormData = {
      Name: initialFormData.projectName,
      Description: data.description,
      ShortDescription: initialFormData.shortDescription,
      Status: 'Ativo',
      UserId: user,
      MicrothemeId: parseInt(initialFormData.microtheme),
    };
    createProjectMutation(completeFormData);
  };

  // Function to handle AI description generation
  const { refetch: generateDescriptionRefetch, isFetching: isGeneratingDescription } = useQuery(
    'generateDescription',
    () => generateDescription({ projectName: initialFormData.projectName, projectDetails: getValues('description') }),
    {
      enabled: false,
      onSuccess: (generatedDescription) => {
        setValue('description', generatedDescription);
      },
      onError: () => {
        Alert.alert('Erro', 'Não foi possível gerar a descrição. Tente novamente.');
      },
    }
  );

  const handleGenerateDescription = async () => {
    generateDescriptionRefetch();
  };

  // State to manage dynamic height of the TextInput
  const [inputHeight, setInputHeight] = useState(200);

  return (
    <View style={styles.wrapper}>
      <ScrollView contentContainerStyle={styles.container}>
        {/* Header text */}
        <Text style={styles.header}>Cadastro de Projeto</Text>
        <Text style={styles.subheader}>
          Utilize esse espaço para descrever seu projeto em mais detalhes, a motivação, o processo e seus diferenciais!
        </Text>

        {/* Project description input */}
        <Controller
          control={control}
          name="description"
          rules={{ required: 'Descrição é obrigatória' }}
          render={({ field: { onChange, value } }) => (
            <>
              <TextInput
                style={[styles.input, { height: Math.max(200, inputHeight) }]}
                value={value}
                onChangeText={onChange}
                multiline
                onContentSizeChange={(e) => setInputHeight(e.nativeEvent.contentSize.height)}
                editable={!isGeneratingDescription}
              />
              {errors.description && <Text style={styles.errorText}>{errors.description.message}</Text>}
            </>
          )}
        />

        <SecondaryButton
          text={"Aprimorar com IA"}
          onPress={handleGenerateDescription}
          disabled={isGeneratingDescription}
        />

        {isGeneratingDescription && (
          <View style={{ marginTop: 20 }}>
            <ActivityIndicator size="large" color={Colors.green400} />
          </View>
        )}
      </ScrollView>

      {/* Submit button */}
      <View style={styles.buttonContainer}>
        <PrimaryButton text="Confirmar" onPress={handleSubmit(onSubmit)} />
      </View>
    </View>
  );
}
