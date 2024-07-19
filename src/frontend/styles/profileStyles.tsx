import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors';

const profileStyles = () => StyleSheet.create({
  greenHeader: {
    height: 90, 
    backgroundColor: Colors.green400,
  },
  container: {
    flex: 1,
    backgroundColor: Colors.white,
    display: 'flex'
  },
  header: {
    paddingVertical: 10,
    backgroundColor: Colors.white,
    paddingHorizontal: '5%'
  },
  headerText: {
    fontSize: 18,
    color: Colors.black,
    marginBottom: 5
  },
  divider: {
    height: 2, 
    backgroundColor: Colors.neutral500,
    marginVertical: 10
  },
  projectHeader: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    paddingVertical: 10,
    width: '100%',
    paddingHorizontal: "5%"
  },
  sectionTitle: {
    fontSize: 18,
    fontWeight: 'bold',
    color: Colors.black,
  },
  plusButton: {
    alignItems: 'center',
    justifyContent: 'center',
  },
  content: {
    flex: 1,
    display: 'flex',
    width: '100%',
    alignItems: 'center'
  },
  headerTextCeo: {
    fontSize: 24,
    fontWeight: 'bold',
    color: Colors.green400,
    marginBottom: 5
  }
});

export default profileStyles;
