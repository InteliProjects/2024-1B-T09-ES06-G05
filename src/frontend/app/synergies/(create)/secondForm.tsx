import React, { useState, useEffect } from 'react';
import { View, Text, ScrollView, ActivityIndicator, Alert } from 'react-native';
import { useForm, Controller, SubmitHandler } from 'react-hook-form';
import { useRouter, useLocalSearchParams } from 'expo-router';
import { useQuery } from 'react-query';
import PrimaryButton from '@/components/primarybutton';
import Microcard from '@/components/microCard';
import secondFormStyles from '@/styles/pages/createSynergy/secondFormStyles';
import useStyles from '@/styles/useStyles';
import { getProject, createSynergy } from '@/services/coreApi';
import Colors from '@/constants/colors';
import DropDownPicker from 'react-native-dropdown-picker';

type FormData = {
  selectedProjects: string[];
  synergyType: string;
};

type Project = {
  id: string;
  name: string;
  enterprise: string;
  user: string;
  macrotheme: string;
  microtheme: string;
};

export default function SecondFormScreen() {
  const router = useRouter();
  const styles = secondFormStyles;
  const globalStyles = useStyles();
  const { formData } = useLocalSearchParams();

  const initialFormData: FormData = formData ? JSON.parse(formData as string) : { selectedProjects: [], synergyType: '' };
  const { control, handleSubmit, setValue } = useForm<FormData>({
    defaultValues: initialFormData,
  });

  const { selectedProjects } = initialFormData;

  useEffect(() => {
    setValue('selectedProjects', selectedProjects);
  }, [selectedProjects]);

  const onSubmit: SubmitHandler<FormData> = async data => {
    try {
      const [targetProject, sourceProject] = data.selectedProjects.map(Number);

      const synergyData = {
        SourceProject: sourceProject,
        TargetProject: targetProject,
        Type: data.synergyType,
        Status: 'Em andamento'
      };

      await createSynergy(synergyData);
      Alert.alert('Sucesso', 'Sinergia criada com sucesso');
      router.replace(`/projects/${Number(data.selectedProjects[1])}`);
    } catch (error) {
      console.error('Erro ao criar sinergia:', error);
      if ((error as any).response && (error as any).response.status === 400) {
        Alert.alert('Erro', 'A sinergia entre esses projetos já existe');
      } else {
        Alert.alert('Erro', 'Erro ao criar sinergia');
      }
    }
  };

  const [synergyTypeOpen, setSynergyTypeOpen] = useState(false);
  const [synergyTypeValue, setSynergyTypeValue] = useState<string | null>(null);
  const [synergyTypeItems, setSynergyTypeItems] = useState([
    { label: 'Aprender', value: 'Aprender' },
    { label: 'Integrar', value: 'Integrar' },
    { label: 'Unificar', value: 'Unificar' },
  ]);

  const { data, isLoading, error } = useQuery<Project[]>(
    ['projects', selectedProjects],
    async () => {
      const fetchedProjectsData = await Promise.all(
        selectedProjects.map(async projectId => await getProject(Number(projectId)))
      );
      return fetchedProjectsData;
    },
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
      <ScrollView contentContainerStyle={styles.container}>
        <Text style={styles.header}>Tipo de Sinergia</Text>
        <Text style={styles.subheader}>Selecione o tipo de sinergia entre os projetos e clique em confirmar!</Text>

        <View style={styles.selectedProjectsContainer}>
          {data?.map(project => (
            <View key={project.id} style={{ marginHorizontal: 8 }}>
              <Microcard
                title={project.name}
                enterprise={project.enterprise}
                user={project.user}
                macrotheme={project.macrotheme}
                microtheme={project.microtheme}
                isSelected={false}
              />
            </View>
          ))}
        </View>

        <Controller
          control={control}
          name="synergyType"
          render={({ field: { onChange, value } }) => (
            <DropDownPicker
              open={synergyTypeOpen}
              value={synergyTypeValue}
              items={synergyTypeItems}
              setOpen={setSynergyTypeOpen}
              setValue={setSynergyTypeValue}
              setItems={setSynergyTypeItems}
              onChangeValue={value => {
                setSynergyTypeValue(value);
                onChange(value);
              }}
              style={styles.picker}
              textStyle={styles.pickerText}
              placeholder="Tipo de sinergia"
              dropDownContainerStyle={styles.dropdown}
              listMode="SCROLLVIEW" 
              dropDownDirection="BOTTOM" // Defines the direction of the dropdown list
              maxHeight={130} // Defines a height limit for the dropdown
            />
          )}
        />
      </ScrollView>

      <View style={styles.buttonContainer}>
        <PrimaryButton text="Confirmar" onPress={handleSubmit(onSubmit)} />
      </View>
    </View>
  );
}