import { StyleSheet, Dimensions } from 'react-native';
import Colors from '@/constants/colors';

const { width } = Dimensions.get('window');
const tileSize = width / 2 - 20;

const macrothemeCardStyles = () => {
  return StyleSheet.create({
    container: {
      width: tileSize,
      height: tileSize,
      margin: 10,
      padding: 10,
      backgroundColor: Colors.green100,
      justifyContent: 'center',
      alignItems: 'center',
      borderRadius: 10,
    },
    title: {
      fontSize: 18,
      fontWeight: 'bold',
      color: Colors.black,
      textAlign: 'center',
    },
  });
};

export default macrothemeCardStyles;