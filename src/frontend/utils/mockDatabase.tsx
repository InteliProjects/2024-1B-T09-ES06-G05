import mockData from './mock.json';

type User = {
  id: number;
  name: string;
  enterprise: string;
  position: string;
  email: string;
  password: string;
};

type Project = {
  id: number;
  name: string;
  shortDescription: string | null;
  description: string;
  status: string;
  macroTheme: string;
  microTheme: string;
  user: string;
  company: string;
};

type MacroTheme = {
  id: number;
  name: string;
};

const users: User[] = mockData.users;
const projects: Project[] = mockData.projects;
const macroThemes: MacroTheme[] = mockData.macroThemes;

export { users, projects, macroThemes };