import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors'; 
import SecondaryButton from '@/components/secondaryButton';

const buttonStyles = StyleSheet.create({
    button: {
        backgroundColor: Colors.green400,
        paddingHorizontal: 20,
        paddingVertical: 10,
        borderRadius: 20,
        alignItems: 'center',
        justifyContent: 'center',
        width: '100%'  
    },
    text: {
        color: 'white',
        fontSize: 20,
        fontWeight: 'bold'
    },
    secondaryButton: {
        marginTop: 15,
        backgroundColor: Colors.white,
        paddingHorizontal: 20,
        paddingVertical: 10,
        borderRadius: 20,
        borderWidth: 3,
        borderColor: Colors.green400,
        alignItems: 'center',
        justifyContent: 'center',
        width: '100%'  
    },
    secondaryText: {
        color: Colors.green400,
        fontSize: 20,
        fontWeight: 'bold'
    },

});

export default buttonStyles;
