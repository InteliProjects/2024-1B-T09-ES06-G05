import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors';

const searchPageStyles = () => {
  return StyleSheet.create({
    container: {
      flex: 1,
      backgroundColor: Colors.white,
      paddingTop: 20,
    },
    list: {
      alignItems: 'flex-start',
    },
    text: {
      fontSize: 18,
      fontWeight: 'bold',
      textAlign: 'center',
      margin: 20,
    },
    link: {
      fontSize: 16,
      color: 'blue',
      textAlign: 'center',
      margin: 10,
    },
  });
};

export default searchPageStyles;
