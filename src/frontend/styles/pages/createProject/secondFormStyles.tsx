import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors';

const secondFormStyles = StyleSheet.create({
    wrapper: {
      flex: 1,
      justifyContent: 'space-between',
    },
    container: {
      flexGrow: 1,
      padding: 16,
      backgroundColor: Colors.white,
    },
    header: {
      fontSize: 24,
      fontWeight: 'bold',
      color: Colors.form,
      marginBottom: 8,
    },
    subheader: {
      fontSize: 16,
      color: Colors.neutral600,
      marginBottom: 16,
    },
    input: {
      borderColor: Colors.form,
      borderWidth: 1,
      borderRadius: 8,
      paddingHorizontal: 8,
      paddingVertical: 10,
      marginBottom: 12,
      fontSize: 14,
      textAlignVertical: 'top',
    },
    buttonContainer: {
      padding: 16,
      backgroundColor: Colors.white,
    },
    errorText: {
      color: Colors.error, 
      marginTop: 10,
    },
});

export default secondFormStyles;