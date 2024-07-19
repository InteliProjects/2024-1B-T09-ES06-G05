import React from 'react';
import { View, FlatList } from 'react-native';
import MacrothemeCard from '@/components/macroThemeCard';
import searchPageStyles from '@/styles/pages/searchPageStyles';
import { useQuery } from 'react-query';
import { getMacrothemes } from '@/services/coreApi';
import { ActivityIndicator } from 'react-native';
import Colors from '@/constants/colors';

interface Macrotheme {
  id: number;
  name: string;
}

export default function Search() {
  const styles = searchPageStyles();

  const { data: macrothemes, isLoading } = useQuery('macrothemes', getMacrothemes);

  if (isLoading) {
    return <ActivityIndicator size="large" color={Colors.green400} />;
  }

  return (
    <View style={styles.container}>
        <FlatList
          data={macrothemes}
          keyExtractor={item => item.id.toString()}
          numColumns={2}
          renderItem={({ item }) => <MacrothemeCard id={item.id} name={item.name} />}
          contentContainerStyle={styles.list}
        />
    </View>
  );
}