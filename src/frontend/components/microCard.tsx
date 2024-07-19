import React from 'react';
import { View, Text } from 'react-native';
import microCardStyles from '@/styles/microCardStyles';

interface MicroCardProps {
  title: string;
  enterprise: string;
  user: string;
  macrotheme: string;
  microtheme: string;
  onPress?: () => void;
  isSelected: boolean; // Add a function to handle the card press
}

const MicroCard: React.FC<MicroCardProps> = ({ title, enterprise, user, macrotheme, microtheme, isSelected }) => {
  const styles = microCardStyles;

  // Aplies the background style class when the card is selected
  const cardStyle = isSelected ? [styles.card, styles.selectedCard] : styles.card;

  return (
    <View style={cardStyle}>
        <Text style={styles.cardTitle} numberOfLines={1}>{title}</Text>
      <Text style={styles.cardCompany} numberOfLines={2}>{enterprise}</Text>
      <Text style={styles.cardPerson} numberOfLines={1}>{user}</Text>
      <View style={styles.separator} />
      <Text style={styles.cardMacrotheme} numberOfLines={2}>{macrotheme}</Text>
      <Text style={styles.cardMicrotheme} numberOfLines={1}>{microtheme}</Text>
    </View>
  );
};

export default MicroCard;
