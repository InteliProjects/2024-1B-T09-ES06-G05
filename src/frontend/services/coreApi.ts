import axios from 'axios';
import { getToken } from '@/utils/authUtils';

const CORE_API_BASE_URL = process.env.EXPO_PUBLIC_CORE_API_BASE_URL;

const coreApi = axios.create({
  baseURL: CORE_API_BASE_URL,
});

export const getRecommendedProjects = async (userId: number) => {
  const token = await getToken(); 
  const response = await coreApi.get(`/projects/users/${userId}/recommendations`, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
};

export const getMacrothemes = async () => {
  const token = await getToken();
  const response = await coreApi.get('/macrothemes', {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
}

export const getMicrothemes = async (macrothemeId: number) => {
  const token = await getToken();
  const response = await coreApi.get(`/macrothemes/${macrothemeId}/microthemes`, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
}

export const getProjectsByMacrotheme = async (macrothemeId: number) => {
  const token = await getToken();
  const response = await coreApi.get(`/macrothemes/${macrothemeId}/projects`, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
}

export const getProject = async (projectId: number) => {
  const token = await getToken();
  const response = await coreApi.get(`/projects/${projectId}`, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
}

export const getProjectsByUserId = async (userId: number) => {
  const token = await getToken(); 
  const response = await coreApi.get(`/projects/users/${userId}`, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
}

export const createSynergy = async (data: any) => {
  const token = await getToken();
  const response = await coreApi.post('/synergies', data, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
}

export const getSynergiesByProjectId = async (projectId: number) => {
  const token = await getToken();
  const response = await coreApi.get(`/projects/${projectId}/synergies`, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
}

export const getProjectRating = async (projectId: number, userId: number) => {
  const token = await getToken();
  const response = await coreApi.get(`/projects/${projectId}/users/${userId}/ratings`, {
    headers: {
      Authorization: `Bearer ${token}`
    }
  });
  return response.data;
}

export const postProjectRating = async (projectId: number, data: any) => {
  console.log(data);
  const token = await getToken();
  const response = await coreApi.post(`/projects/${projectId}/ratings`, data, {
    headers: {
      Authorization: `Bearer ${token}`
    }
  });
  return response.data;
}

export const generateDescription = async (data: { projectName: string; projectDetails: string }) => {
  const token = await getToken();
  const response = await coreApi.post('/projects/generate-description', data, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
};

export const createProject = async (data: any) => {
  console.log(data);
  const token = await getToken();
  const response = await coreApi.post('/projects', data, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
};

export const getUserById = async (userId: number) => {
  const token = await getToken();
  const response = await coreApi.get(`/users/${userId}`, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
}

export const deleteProject = async (projectId: number) => {
  const token = await getToken();
  const response = await coreApi.delete(`/projects/${projectId}`, {
    headers: {
      Authorization: `Bearer ${token}` 
    }
  });
  return response.data;
}
