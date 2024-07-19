import { View, ActivityIndicator, Text } from "react-native";
import React from "react";
import Initialize from "@/utils/initialize";
import useStyles from "@/styles/useStyles";
import InfiniteFeed from "@/components/feed";
import { useQuery } from 'react-query';
import { getRecommendedProjects } from '@/services/coreApi';
import Colors from '@/constants/colors';
import { useAuth } from '@/hooks/auth.context';

export default function App() {
  // Get the user id from the context
  const { user: userId } = useAuth();

  // Importing styles
  const styles = useStyles();

  // Fetch recommended projects
  const { data: projects, isLoading } = useQuery(['recommendedProjects', userId], () => getRecommendedProjects(Number(userId)), {
    enabled: !!userId,
  });

  return (
    // Initialize component to load the necessary fonts
    <Initialize> 
      <View style={styles.container}>
        {isLoading ? (
          <ActivityIndicator size="large" color={Colors.green400} />
        ) : (
          userId && projects ? <InfiniteFeed title="Projetos Recomendados" data={projects} /> : <View />
        )}
      </View>
    </Initialize>
  );
}
