import axios from 'axios';

const AUTH_API_BASE_URL = process.env.EXPO_PUBLIC_AUTH_API_BASE_URL;

const authApi = axios.create({
  baseURL: AUTH_API_BASE_URL,
});

export const login = async (email: string, password: string) => {
  const response = await authApi.post('/login', { email, password });
  return response.data;
};