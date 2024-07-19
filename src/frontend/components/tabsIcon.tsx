import React from 'react';
import { Ionicons } from '@expo/vector-icons';
import Colors from '@/constants/colors';
import { Tabs } from 'expo-router';

// Creates a tab navigation screen (Tabs.Screen) with configured icon and title
export default function TabsIcon(pageName: string, headerTitle: string, iconName: keyof typeof Ionicons['glyphMap']) {
    return (
        <Tabs.Screen
            name={pageName}
            options={{
                title: headerTitle,
                tabBarIcon: ({ color, size, focused }) => ( // Renders the icon
                    <Ionicons
                        name={iconName} 
                        size={size} 
                        color={focused ? Colors.white : color} // Defines the color of the icon based on focus
                        style={{
                            backgroundColor: focused ? Colors.green400 : 'transparent', // Changes the background color of the icon based on focus
                            borderRadius: 50,
                            padding: 10, 
                        }}
                    />
                ),
            }}
        />
    );
}