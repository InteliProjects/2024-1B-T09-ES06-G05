import React from 'react';
import { View, Text, SafeAreaView, TouchableOpacity, ActivityIndicator, FlatList } from 'react-native';
import profileStyles from '@/styles/profileStyles';
import { AntDesign } from '@expo/vector-icons';  
import InfiniteFeed from "@/components/feed";
import { useAuth } from '@/hooks/auth.context';
import { router } from 'expo-router';
import { useQuery } from 'react-query';
import { getProjectsByUserId, getUserById } from '@/services/coreApi';
import Colors from '@/constants/colors';

const ProfilePage = () => {
  const { user } = useAuth();
  const styles = profileStyles();

  const { data: userData, isLoading: isLoadingUser } = useQuery(['userData', user], () => getUserById(Number(user)), {
    enabled: !!user,
  });

  const { data: projects, isLoading: isLoadingProjects } = useQuery(['userProjects', user], () => getProjectsByUserId(Number(user)), {
    enabled: !!user,
  });

  const handleAddProject = () => {
    router.push('/projects/firstForm');
  };

  if (isLoadingUser || isLoadingProjects) {
    return <ActivityIndicator size="large" color={Colors.green400} />;
  }

  const renderHeader = () => (
    <View>
      <View style={styles.greenHeader}></View>
      <View style={styles.header}>
        <Text style={styles.headerTextCeo}>{userData ? userData.name : 'CEO'}</Text>
        <Text style={styles.headerText}>{userData && userData.company ? userData.company : 'Empresa'}</Text>
        <View style={styles.divider}></View>
      </View>
    </View>
  );

  return (
    <SafeAreaView style={{ flex: 1, backgroundColor: Colors.white }}>
      <FlatList
        data={projects}
        keyExtractor={(item) => item.id.toString()}
        ListHeaderComponent={renderHeader}
        renderItem={({ item }) => null} 
        ListFooterComponent={() => (
          <InfiniteFeed 
            title="Meus Projetos" 
            data={projects}
            headerRight={
              <TouchableOpacity onPress={handleAddProject} style={{ marginRight: 15 }}>
                <AntDesign name="pluscircle" size={48} color={Colors.green400} />
              </TouchableOpacity>
            }
          />
        )}
      />
    </SafeAreaView>
  );
};

export default ProfilePage;