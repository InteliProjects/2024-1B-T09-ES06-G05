import React, { useState } from 'react';
import { View, ActivityIndicator } from "react-native";
import useStyles from "@/styles/useStyles";
import InfiniteFeed from '@/components/feed';
import SearchBar from '@/components/searchBar';
import { useLocalSearchParams } from 'expo-router';
import { useQuery } from 'react-query';
import { getProjectsByMacrotheme } from '@/services/coreApi';
import Colors from '@/constants/colors';

export default function Projects() {
  const { macrothemeId, macrotheme } = useLocalSearchParams();
  const [searchQuery, setSearchQuery] = useState('');

  // Importing styles
  const styles = useStyles();

  const { data: projects, isLoading } = useQuery(['projectsByMacrotheme', macrothemeId], () => getProjectsByMacrotheme(Number(macrothemeId)), {
    enabled: !!macrothemeId,
  });

  const filteredProjects = projects?.filter((project: any) => project.name.toLowerCase().includes(searchQuery.toLowerCase())) || [];

  return (
    <View style={styles.container}>
      {isLoading ? (
        <ActivityIndicator size="large" color={Colors.green400} />
      ) : (
        <>
        <View style={styles.search}>
          <SearchBar onSearch={setSearchQuery} />
        </View>
          {macrothemeId && projects ? <InfiniteFeed title={`${macrotheme}`} data={filteredProjects} /> : <View />}
        </>
      )}
    </View>
  );
}
