import { StyleSheet } from 'react-native';
import Colors from '@/constants/colors';

const projectPageStyles = StyleSheet.create({
    separator: {
        borderBottomColor: Colors.neutral200,
        borderBottomWidth: 3,
        marginTop: 30,
        marginVertical: 8,
    },
    container: {
        flex: 1,
        padding: 16,
        backgroundColor: Colors.white
    },
    loadingContainer: {
        flex: 1,
        backgroundColor: Colors.white,
        alignItems: 'center',
        justifyContent: 'center',
    },
    title: {
        fontSize: 24,
        fontWeight: 'bold',
        color: Colors.green400,

    },
    macrotheme: {
        fontSize: 12,
        fontWeight: 'bold',
        color: Colors.neutral600,
        marginBottom: 12,
    },
    company: {
        fontSize: 12,
        fontWeight: 'bold',
        color: Colors.black,

    },
    user: {
        fontSize: 12,
        fontWeight: 'semibold',
        color: Colors.neutral600,
        marginBottom: 16,
    },
    shortDescription: {
        fontSize: 16,
        color: Colors.neutral800,
        marginBottom: 35,
        flexWrap: 'wrap',

    },
    description: {
        fontSize: 16,
        color: Colors.neutral800,
        marginBottom: 35,
        flexWrap: 'wrap',

    },
    text: {
        fontSize: 16,
        fontWeight: 'bold',
        color: Colors.green500,
        marginBottom: 16,
    },
    link: {
        fontSize: 14,
        color: Colors.green500,
        marginBottom: 8,
    },
    ratingContainer: {
        alignItems: 'center',
        marginVertical: 16,
    },
    ratingTitle: {
        fontSize: 16,
        fontWeight: 'bold',
        color: Colors.green500,
        marginBottom: 8,
    },
    circleContainer: {
        flexDirection: 'row',
        justifyContent: 'center', 
        alignItems: 'center',
    },
    circle: {
        width: 25,
        height: 25,
        borderRadius: 15,
        margin: 14,
        backgroundColor: Colors.neutral500
    },
    synergiesContainer: {
        flexDirection: 'row',
        flexWrap: 'nowrap',
        padding : 16,
    },
    icon : {
        marginHorizontal: 8, 
    }
});

export default projectPageStyles;