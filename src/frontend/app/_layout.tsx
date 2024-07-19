import React from 'react';
import { QueryClient, QueryClientProvider } from 'react-query';
import StackNavigator from "@/components/navigation/stacknavigator";
import { AuthProvider } from '@/hooks/auth.context';

// Create a new QueryClient instance
const queryClient = new QueryClient();

export default function Layout() {
    return (
        // Wrap the entire app in the QueryClientProvider
        <AuthProvider>
            <QueryClientProvider client={queryClient}>
                {/* The StackNavigator component will contain all the screens of the app */}
                <StackNavigator />
            </QueryClientProvider>
        </AuthProvider>
      );
}