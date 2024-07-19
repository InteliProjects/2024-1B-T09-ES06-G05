import React, { useState } from 'react';
import { View, Text, TextInput, ScrollView } from 'react-native';
import { useForm, Controller, SubmitHandler } from 'react-hook-form';
import { useRouter } from 'expo-router';
import DropDownPicker from 'react-native-dropdown-picker';
import PrimaryButton from '@/components/primarybutton';
import firstFormStyles from '@/styles/pages/createProject/firstFormStyles';
import { getMacrothemes, getMicrothemes } from '@/services/coreApi';
import { useQuery } from 'react-query';

// Define the form data type
type FormData = {
  projectName: string;
  macrotheme: string;
  microtheme: string;
  shortDescription: string;
};

// Define the type for Macrotheme and Microtheme
type Theme = {
  id: number;
  name: string;
};

export default function FirstFormScreen() {
  const { control, handleSubmit, getValues, setValue, formState: { errors } } = useForm<FormData>({
    defaultValues: {
      projectName: '',
      macrotheme: '',
      microtheme: '',
      shortDescription: '',
    },
  });

  const router = useRouter();
  const styles = firstFormStyles;
  const [macrothemeOpen, setMacrothemeOpen] = useState(false);
  const [microthemeOpen, setMicrothemeOpen] = useState(false);
  const [macrothemeValue, setMacrothemeValue] = useState<number | null>(null);
  const [microthemeValue, setMicrothemeValue] = useState<number | null>(null);

  const { data: macrothemes = [] } = useQuery<Theme[]>('macrothemes', getMacrothemes);
  const { data: microthemes = [], refetch: refetchMicrothemes } = useQuery<Theme[]>(
    ['microthemes', macrothemeValue],
    () => getMicrothemes(macrothemeValue!),
    { enabled: !!macrothemeValue }
  );

  const onSubmit: SubmitHandler<FormData> = data => {
    router.push({
      pathname: 'projects/secondForm',
      params: { formData: JSON.stringify({ ...getValues(), ...data }) },
    });
  };

  const handleMacrothemeChange = (value: number) => {
    setMacrothemeValue(value);
    setValue('microtheme', '');
    refetchMicrothemes();
  };

  return (
    <View style={styles.wrapper}>
      <ScrollView contentContainerStyle={styles.container}>
        <Text style={styles.header}>Cadastro de Projeto</Text>
        <Text style={styles.subheader}>
          Preencha os campos com as informações abaixo para registrar seu projeto dentro do LegacyLab!
        </Text>

        <Text style={styles.inputLabel}>Nome do projeto</Text>
        <Controller
          control={control}
          name="projectName"
          rules={{ required: 'Nome do projeto é obrigatório' }}
          render={({ field: { onChange, value } }) => (
            <>
              <TextInput
                style={styles.input}
                value={value}
                onChangeText={onChange}
              />
              {errors.projectName && <Text style={styles.errorText}>{errors.projectName.message}</Text>}
            </>
          )}
        />

        <Text style={styles.inputLabel}>Macrotema</Text>
        <View style={macrothemeOpen ? styles.dropdownWrapperOpen : styles.dropdownWrapperClosed}>
          <Controller
            control={control}
            name="macrotheme"
            rules={{ required: 'Macrotema é obrigatório' }}
            render={({ field: { onChange, value } }) => (
              <>
                <DropDownPicker
                  open={macrothemeOpen}
                  value={macrothemeValue}
                  items={macrothemes.map((item: Theme) => ({ label: item.name, value: item.id }))}
                  setOpen={setMacrothemeOpen}
                  setValue={setMacrothemeValue}
                  onChangeValue={(value: number | null) => {
                    if (value !== null) {
                      handleMacrothemeChange(value);
                      onChange(value.toString());
                    }
                  }}
                  style={styles.picker}
                  textStyle={styles.pickerText}
                  placeholder="Selecione um Macrotema"
                  dropDownContainerStyle={styles.dropdown}
                  listMode="SCROLLVIEW"
                  dropDownDirection="BOTTOM" // Defines the direction of the dropdown list
                  maxHeight={130} // Defines a height limit for the dropdown
                />
                {errors.macrotheme && <Text style={[styles.errorText, { marginTop: macrothemeOpen ? 0 : 20 }]}>{errors.macrotheme.message}</Text>}
              </>
            )}
          />
        </View>

        <Text style={styles.inputLabel}>Microtema</Text>
        <View style={microthemeOpen ? styles.dropdownWrapperOpen : styles.dropdownWrapperClosed}>
          <Controller
            control={control}
            name="microtheme"
            rules={{ required: 'Microtema é obrigatório' }}
            render={({ field: { onChange, value } }) => (
              <>
                <DropDownPicker
                  open={microthemeOpen}
                  value={microthemeValue}
                  items={microthemes.map((item: Theme) => ({ label: item.name, value: item.id }))}
                  setOpen={setMicrothemeOpen}
                  setValue={setMicrothemeValue}
                  setItems={() => {}}
                  onChangeValue={(value: number | null) => {
                    if (value !== null) {
                      onChange(value.toString());
                    }
                  }}
                  style={styles.picker}
                  textStyle={[styles.pickerText, !macrothemeValue && styles.disabledPickerText]}
                  placeholder="Selecione um Microtema"
                  dropDownContainerStyle={styles.dropdown}
                  disabled={!macrothemeValue}
                  listMode="SCROLLVIEW"
                  dropDownDirection="BOTTOM" // Defines the direction of the dropdown list
                  maxHeight={130} // Defines a height limit for the dropdown
                />

                {errors.microtheme && <Text style={[styles.errorText, { marginTop: microthemeOpen ? 0 : 20 }]}>{errors.microtheme.message}</Text>}
              </>
            )}
          />
        </View>

        <Text style={styles.inputLabel}>Resumo do projeto</Text>
        <Controller
          control={control}
          name="shortDescription"
          rules={{ required: 'Resumo do projeto é obrigatório' }}
          render={({ field: { onChange, value } }) => (
            <>
              <TextInput
                style={[styles.input, styles.textArea]}
                value={value}
                onChangeText={onChange}
                multiline
              />
              {errors.shortDescription && <Text style={styles.errorText}>{errors.shortDescription.message}</Text>}
            </>
          )}
        />
      </ScrollView>

      <View style={styles.buttonContainer}>
        <PrimaryButton text="Continuar" onPress={handleSubmit(onSubmit)} />
      </View>
    </View>
  );
}
