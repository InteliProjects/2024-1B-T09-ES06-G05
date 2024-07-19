import React from 'react';
import { TouchableOpacity, Text } from 'react-native';
import styles from '@/styles/buttonStyles';

interface ButtonProps {
    text: string;
    onPress?: () => void;
    disabled?: boolean;
}

const SecondaryButton: React.FC<ButtonProps> = ({ text, onPress, disabled }) => {
    return (
        <TouchableOpacity style={styles.secondaryButton} onPress={onPress} disabled={disabled}>
            <Text style={styles.secondaryText}>{text}</Text>
        </TouchableOpacity>
    );
}

export default SecondaryButton;
