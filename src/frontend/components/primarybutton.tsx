import React from 'react';
import { TouchableOpacity, Text } from 'react-native';
import styles from '@/styles/buttonStyles';

interface ButtonProps {
    text: string;
    onPress?: () => void;
}

const PrimaryButton: React.FC<ButtonProps> = ({ text, onPress }) => {
    return (
        <TouchableOpacity style={styles.button} onPress={onPress}>
            <Text style={styles.text}>{text}</Text>
        </TouchableOpacity>
    );
}

export default PrimaryButton;
