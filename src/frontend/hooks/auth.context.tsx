import React, {
    createContext,
    Dispatch,
    ReactElement,
    ReactNode,
    SetStateAction,
    useContext,
    useEffect,
    useState
} from "react";
import AsyncStorage from '@react-native-async-storage/async-storage';

type AuthContextType = {
    user: number | null;
    setUser: Dispatch<SetStateAction<number | null>>;
};

const AuthContext = createContext<AuthContextType | undefined>(undefined);

function useAuth(): AuthContextType {
    const context = useContext(AuthContext);
    if (!context) {
        throw new Error("useAuth must be used within an AuthProvider");
    }
    return context;
}

const AuthProvider = (props: { children: ReactNode }): ReactElement => {
    const [user, setUser] = useState<number | null>(null);

    useEffect(() => {
        const loadUser = async () => {
            try {
                const storedUser = await AsyncStorage.getItem('user');
                if (storedUser !== null) {
                    setUser(parseInt(storedUser, 10));
                }
            } catch (e) {
                console.error("Failed to load user from storage", e);
            }
        };

        loadUser();
    }, []);

    useEffect(() => {
        const saveUser = async () => {
            try {
                if (user !== null) {
                    await AsyncStorage.setItem('user', user.toString());
                } else {
                    await AsyncStorage.removeItem('user');
                }
            } catch (e) {
                console.error("Failed to save user to storage", e);
            }
        };

        saveUser();
    }, [user]);

    return <AuthContext.Provider {...props} value={{ user, setUser }} />;
};

export { AuthProvider, useAuth };
