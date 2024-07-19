import Colors from '@/constants/colors';
import { StyleSheet } from 'react-native';

const firstFormStyles = StyleSheet.create({
  cardsContainer: {
    // Divides in 2 columns
    display: 'flex',
    flexDirection: 'row',
    flexWrap: 'wrap',
    justifyContent: 'space-between',
  },
  wrapper: {
    flex: 1,
    backgroundColor: Colors.white,
  },
  contentContainer: {
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
  card: {
    // borderWidth: 1,
    // borderColor: '#ddd',
    // borderRadius: 8,
    // marginBottom: 15,
  },
  selectedCard: {
    borderColor: Colors.green600 ,
    backgroundColor: Colors.green100,
  },
  buttonContainer: {
    padding: 20,
    borderTopWidth: 1,
    borderTopColor: Colors.neutral200,
  },
});

export default firstFormStyles;
