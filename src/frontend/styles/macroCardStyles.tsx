import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors';

const macrocardStyles = () => {
    return StyleSheet.create({
        card: {
            backgroundColor: 'white',
            padding: 16,
            borderRadius: 8,
            shadowColor: Colors.black,
            shadowOffset: { width: 0, height: 2 },
            shadowOpacity: 0.3,
            shadowRadius: 8,
            elevation: 5,
            marginVertical: 5,
            width: '97%',
        },
        cardTitle: {
            fontSize: 20,
            marginBottom: 4,
            fontFamily: 'Poppins-SemiBold',
        },
        cardCompany: {
            fontSize: 16,
            marginBottom: 4,
            fontFamily: 'Poppins-SemiBold',
        },
        cardPerson: {
            fontSize: 14,
            marginBottom: 4,
            color: Colors.neutral600,
            fontFamily: 'Poppins-Regular',
        },
        separator: {
            borderBottomColor: Colors.neutral200,
            borderBottomWidth: 3,
            marginVertical: 8,
        },
        cardCategory: {
            fontSize: 12,
            color: Colors.neutral600,
            marginBottom: 8,
            fontFamily: 'Poppins-Regular',
        },
        cardDescription: {
            fontSize: 14,
            color: Colors.neutral800,
            fontFamily: 'Poppins-Regular',
        },
    });
};

export default macrocardStyles;
