import { useAppSelector } from "./useTypedSelector";

export const useAuth = () => useAppSelector((state) => state.user);
