import { Stack } from 'expo-router';
import React from 'react';
import Colors from '@/constants/colors';

// Main function to render the StackNavigator
export default function StackNavigator() {
    return(
        <Stack
            // Global screen options for the stack
            screenOptions={{
                headerStyle: {
                    backgroundColor: Colors.white, // Set header background color
                },
            }}
        >
            {/* Define each screen in the stack with respective options */}
            {/* Hide header for the tab navigator */}
            <Stack.Screen name="(tabs)" options={{ headerShown: false }} />
            <Stack.Screen name="index" options={{ headerShown: false }} />

            {/* Define other screens with empty titles */}
            <Stack.Screen name="projects/[id]" options={{ title: "" }} />
            
            <Stack.Screen name="projects/(create)/firstForm" options={{ title: "" }} />
            <Stack.Screen name="projects/(create)/secondForm" options={{ title: "" }} />

            <Stack.Screen name="synergies/(create)/firstForm" options={{ title: "" }} />
            <Stack.Screen name="synergies/(create)/secondForm" options={{ title: "" }} />
            <Stack.Screen name="projects/filtered" options={{ title: "" }} />
        </Stack>
    )
}
