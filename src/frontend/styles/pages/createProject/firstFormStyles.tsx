import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors';

const firstFormStyles = StyleSheet.create({
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
  inputLabel: {
    fontSize: 14,
    color: Colors.neutral600,
    marginBottom: 4,
  },
  input: {
    height: 48,
    borderColor: Colors.form,
    borderWidth: 1,
    borderRadius: 8,
    paddingHorizontal: 8,
    marginBottom: 12,
    fontSize: 14,
  },
  textArea: {
    height: 150,
    textAlignVertical: 'top',
    paddingVertical: 10,
  },
  dropdownWrapperOpen: {
    marginBottom: 150, // Adjust margin to provide space for the dropdown when open
  },
  dropdownWrapperClosed: {
    marginBottom: 40,
  },
  picker: {
    borderColor: Colors.form,
    borderWidth: 1,
    borderRadius: 8,
    justifyContent: 'center',
    height: 40,
  },
  pickerText: {
    fontSize: 14,
  },
  dropdown: {
    borderColor: Colors.form,
    borderRadius: 8,
  },
  buttonContainer: {
    padding: 16,
    backgroundColor: Colors.white,
  },
  errorText: {
    color: Colors.error,
    marginBottom: 20,
  },
  disabledPickerText: {
    color: Colors.neutral500,
  },
});

export default firstFormStyles;