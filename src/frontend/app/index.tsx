import React, { useState } from 'react';
import { View, Text, TextInput, ImageBackground, Alert } from 'react-native';
import PrimaryButton from '@/components/primarybutton';
import LoginStyles from '@/styles/loginScreenStyles';
import { router } from 'expo-router';
import { login } from '@/services/authApi';
import { storeToken } from '@/utils/authUtils';
import { useAuth } from '@/hooks/auth.context';

const LoginScreen = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');

  const { setUser, user } = useAuth();

  const handleLogin = async () => {
    try {
      const response = await login(username, password);
      storeToken(response.token);
      setUser(response.id);
      router.navigate('home');
    } catch (error) {
      Alert.alert('Erro de Login', 'Usuário ou senha inválidos.');
    }
  };

  return (
    <View style={LoginStyles.container}>
      <ImageBackground
        source={require('@/assets/images/login.png')}
        style={LoginStyles.imageBackground}
        resizeMode="cover"
      />
      <View style={LoginStyles.inputContainer}>
        <Text style={LoginStyles.label}>Usuário</Text>
        <TextInput
          style={LoginStyles.input}
          onChangeText={setUsername}
          placeholder="Digite seu usuário"
          placeholderTextColor="#999"
        />
        <Text style={LoginStyles.label}>Senha</Text>
        <TextInput
          style={LoginStyles.input}
          placeholder="Digite sua senha"
          onChangeText={setPassword}
          placeholderTextColor="#999"
          secureTextEntry
        />
      </View>
      <PrimaryButton text="Login" onPress={handleLogin} />
    </View>
  );
};

export default LoginScreen;