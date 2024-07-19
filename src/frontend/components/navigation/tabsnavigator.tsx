import { Tabs } from 'expo-router';
import React from 'react';
import Colors from '@/constants/colors';
import { Ionicons } from '@expo/vector-icons';
import TabsIcon from '@/components/tabsIcon';
import { TouchableOpacity } from 'react-native';
import Initialize from '@/utils/initialize';

// Main function to render the TabsNavigator
export default function TabsNavigator() {
  return (
    <Initialize>
      <Tabs
        screenOptions={({ route }) => ({
          tabBarStyle: {
            backgroundColor: Colors.white,
            height: 60,
          },
          tabBarLabelStyle: {
            display: 'none', // Hide the tab labels
          },
          tabBarActiveTintColor: Colors.green600,
          tabBarInactiveTintColor: Colors.black,
          headerShown: route.name !== 'profile/index',
          headerRight: () =>
            route.name === "profile/index" ? null : ( // Remove notification icon only on profile screen
              <TouchableOpacity onPress={() => console.log('Notificações')}>
                <Ionicons name="notifications" size={24} color={Colors.green600} style={{ marginRight: 10 }} />
              </TouchableOpacity>
            ),
          headerTitleStyle: {
            fontFamily: 'Poppins-Bold',
            fontSize: 22,
            color: Colors.green600
          }
        })}
      >
        {/* Define each tab with its icon and title */}
        {TabsIcon('home', 'LegacyLab', 'home-sharp')}
        {TabsIcon('search/index', 'LegacyLab', 'search')}
        
        <Tabs.Screen
            name={"profile/index"}
            options={{
                title: '',
                tabBarIcon: ({ color, size, focused }) => (
                    <Ionicons
                        name='person' 
                        size={size} 
                        color={focused ? Colors.white : color}
                        style={{
                            backgroundColor: focused ? Colors.green400 : 'transparent',
                            borderRadius: 50,
                            padding: 10,
                        }}
                    />
                ),
                headerStyle: {
                    backgroundColor: Colors.green400, // Set the specific color for the profile header,
                    height: 100
                }
            }}
        />
      </Tabs>
    </Initialize>
  );
}
