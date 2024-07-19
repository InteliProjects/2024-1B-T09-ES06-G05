import React from 'react';
import { Text } from 'react-native';
import macrothemeCardStyles from '@/styles/macrothemeCardStyles';
import { Pressable } from 'react-native';
import { useRouter } from 'expo-router';

interface MacrothemeProps {
  id: number;
  name: string;
}

const MacrothemeCard: React.FC<MacrothemeProps> = ({ id, name }) => {
  const styles = macrothemeCardStyles();
  const router = useRouter();

  const handlePress = () => {
    router.navigate({
      pathname: '/projects/filtered',
      params: { macrothemeId: id, macrotheme: name }
    });
  };

  return (
    <Pressable onPress={handlePress} style={styles.container}>
      <Text style={styles.title}>{name}</Text>
    </Pressable>
  );
};

export default MacrothemeCard;