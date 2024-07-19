import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors';

const useStyles = () => {
    return StyleSheet.create({
        container: {
            flex: 1,
            alignItems: 'center',
            justifyContent: 'center',
            backgroundColor: Colors.white,
        },
        search: {
            paddingHorizontal: 20,
        },
        title: {
            fontFamily: 'Poppins-SemiBold',
            fontSize: 24,
            color: Colors.green500
        },
        text: {
            fontFamily: 'Poppins-Regular',
        },
        link: {
            fontFamily: 'Poppins-Bold',
        },
    });
};

export default useStyles;
