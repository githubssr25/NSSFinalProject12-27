import { Navigate } from "react-router-dom";

const AuthorizedRoute = ({ loggedInUser, children }) => {
  if (!loggedInUser) {
    return <Navigate to="/login" replace />;
  }
  return children;
};

export default AuthorizedRoute;
