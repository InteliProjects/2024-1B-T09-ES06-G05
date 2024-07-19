import { StyleSheet, Dimensions } from 'react-native';
import Colors from '@/constants/colors';

const { width, height } = Dimensions.get('window');

const LoginStyles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: Colors.white,
    alignItems: 'center',
    justifyContent: 'flex-start',
    paddingTop: 0,
    padding: 16,
  },
  imageBackground: {
    width: width,
    height: height * 0.4, 
    justifyContent: 'center',
    alignItems: 'center',
  },
  inputContainer: {
    width: '100%',
    marginTop: 20,
  },
  label: {
    fontSize: 14,
    color: Colors.green500,
    marginBottom: 12,
  },
  input: {
    width: '100%',
    height: 40,
    borderColor: Colors.green500,
    borderBottomWidth: 2,
    marginBottom: 24,
    fontSize: 12,
    color: Colors.black,
  },
  loginButton: {
    marginTop: 20,
  },
  link: {
    fontSize: 14,
    color: Colors.green500,
    marginBottom: 8,
  },
});

export default LoginStyles;
