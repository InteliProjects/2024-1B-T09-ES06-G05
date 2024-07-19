import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors';

const searchBarStyles = () => {
  return StyleSheet.create({
    container: {
      flexDirection: 'row',
      alignItems: 'center',
      backgroundColor: Colors.white,
      borderRadius: 12,
      borderWidth: 2,
      borderColor: Colors.green300,
      paddingHorizontal: 10,
      paddingVertical: 7,
      marginTop: 20,
      width: '100%',
      alignSelf: 'center',
    },
    icon: {
      marginRight: 10,
    },
    input: {
      flex: 1,
      fontSize: 16,
      color: Colors.black,
      fontFamily: 'Poppins-Regular',
    },
  });
};

export default searchBarStyles;
