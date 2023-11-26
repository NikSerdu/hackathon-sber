import Cookies from "js-cookie";
import { FC, PropsWithChildren, useEffect } from "react";
import { useLocation } from "react-router-dom";
import { useAuth } from "../hooks/UseAuth";
import { useActions } from "../hooks/useActions";
const AuthProvider: FC<PropsWithChildren> = ({ children }) => {
  const { user } = useAuth();
  const { checkAuth, logout } = useActions();
  const location = useLocation();
  useEffect(() => {
    const accessToken = Cookies.get("accessToken");
    if (accessToken) {
      checkAuth();
    }
  }, []);
  useEffect(() => {
    const refreshToken = Cookies.get("refreshToken");
    if (!refreshToken && user) {
      logout();
    }
    console.log(location.pathname);
  }, [location.pathname]);
  return <>{children}</>;
};

export default AuthProvider;
