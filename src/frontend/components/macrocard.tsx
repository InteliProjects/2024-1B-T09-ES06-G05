import React from 'react';
import { View, Text, Pressable } from 'react-native';
import macrocardStyles from '@/styles/macroCardStyles';
import { useRouter } from 'expo-router';

// Define the interface for the component's props
interface MacrothemeCardProps {
  id: number;
  name: string;
  shortDescription: string;
  status: string;
  user: string;
  enterprise: string;
  macrotheme: string;
  microtheme: string;
}

// Define the MacrothemeCard functional component with props adhering to the MacrothemeCardProps interface
const MacrothemeCard: React.FC<MacrothemeCardProps> = ({ id, name, shortDescription, status, user, enterprise, macrotheme,  microtheme}) => {
  const styles = macrocardStyles();
  const router = useRouter();

  const handlePress = () => {
    // Navigate to a new screen or perform some action
    router.push('/projects/' + id);
  };

  // Render the card with the provided information
  return (
      <Pressable onPress={handlePress} style={styles.card}>
        <Text style={styles.cardTitle}>{name}</Text>
        <Text style={styles.cardCompany}>{enterprise}</Text>
        <Text style={styles.cardPerson}>{user}</Text>
        <View style={styles.separator} />
        <Text style={styles.cardCategory}>{macrotheme}</Text>
        <Text style={styles.cardCategory}>{microtheme}</Text>
        <Text style={styles.cardDescription}>{shortDescription}</Text>
      </Pressable>
  );
};

export default React.memo(MacrothemeCard, (prevProps, nextProps) => {
  return prevProps.id === nextProps.id &&
    prevProps.name === nextProps.name &&
    prevProps.shortDescription === nextProps.shortDescription &&
    prevProps.status === nextProps.status &&
    prevProps.user === nextProps.user &&
    prevProps.enterprise === nextProps.enterprise &&
    prevProps.macrotheme === nextProps.macrotheme &&
    prevProps.microtheme === nextProps.microtheme;
});
