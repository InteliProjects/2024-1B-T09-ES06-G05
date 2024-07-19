import Colors from '@/constants/colors';
import { StyleSheet } from 'react-native';

const secondFormStyles = StyleSheet.create({
  wrapper: {
    flex: 1,
    backgroundColor: Colors.white,
  },
  container: {
    padding: 20,
  },
  header: {
    fontSize: 24,
    fontWeight: 'bold',
    color: Colors.green500,
    marginBottom: 10,
  },
  subheader: {
    fontSize: 16,
    color: Colors.neutral700,
    marginBottom: 20,
  },
  picker: {
    marginBottom: 150,
  },
  pickerText: {
    fontSize: 16,
  },
  dropdown: {
    borderWidth: 1,
    borderColor: Colors.neutral200,
  },
  buttonContainer: {
    padding: 20,
    borderTopWidth: 1,
    borderTopColor: Colors.neutral200,
  },
  selectedProjectsContainer: {
    flexDirection: 'row', 
    alignItems: 'center', 
    justifyContent: 'flex-start',
    marginTop: 10, 
    paddingHorizontal: 10, 
  }
});

export default secondFormStyles;
