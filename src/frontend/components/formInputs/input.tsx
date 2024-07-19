import React from 'react';
import { View, TextInput } from 'react-native';
import searchBarStyles from '@/styles/searchBarStyles';
import Colors from '@/constants/colors';

// Define the SearchBar functional component
const InputText = () => {
  const styles = searchBarStyles();

  // Render the search bar component
  return (
    <View style={styles.container}>
      <TextInput
        style={styles.input}
        placeholder="Buscar..."
        placeholderTextColor= {Colors.neutral500}
      />
    </View>
  );
};

export default InputText;
