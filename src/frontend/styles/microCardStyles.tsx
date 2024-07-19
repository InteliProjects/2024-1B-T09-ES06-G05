import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors';

const microCardStyles = StyleSheet.create({
  selectedCard: {
    backgroundColor: Colors.green100,
  },
  cardContainer: {
    marginRight: 16,
  },
  card: {
    backgroundColor: Colors.white,
    borderRadius: 8,
    shadowColor: Colors.black,
    shadowOffset: {
      width: 0,
      height: 2,
    },
    shadowOpacity: 0.25,
    shadowRadius: 3.84,
    elevation: 5,
    width: 160,
    height: 150,
    alignSelf: 'center',
    padding: 10,
    marginBottom: 30, 
  },
  cardTitle: {
    fontSize: 16,
    fontWeight: 'bold',
    color: Colors.black,

  },
  cardCompany: {
    fontSize: 12,
  },
  cardPerson: {
    fontSize: 10,
    color: Colors.neutral600,
  },
  separator: {
    height: 1,
    backgroundColor: Colors.neutral200,
    marginVertical: 5,
  },
  cardMacrotheme: {
    fontSize: 14,
    fontWeight: 'bold',
    color: Colors.neutral600,
  },
  cardMicrotheme: {
    fontSize: 14,
    color: Colors.neutral800,
  },
});

export default microCardStyles;
