import React from 'react';
import { View, TextInput } from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import searchBarStyles from '@/styles/searchBarStyles';
import Colors from '@/constants/colors';

interface SearchBarProps {
  onSearch: (query: string) => void;
}

// Define the SearchBar functional component
const SearchBar: React.FC<SearchBarProps> = ({ onSearch }) => {
  const styles = searchBarStyles();

  // Render the search bar component
  return (
    <View style={styles.container}>
      <Ionicons name="search" size={24} color={Colors.neutral500} style={{ marginRight: 10 }} />
      <TextInput
        style={styles.input}
        placeholder="Buscar..."
        placeholderTextColor={Colors.neutral500}
        onChangeText={onSearch}
      />
    </View>
  );
};

export default SearchBar;
