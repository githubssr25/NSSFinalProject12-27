import { Link } from "react-router-dom";

/* eslint-disable react/prop-types */
export const NavBar = ({ loggedInUser, setLoggedInUser }) => {
  const handleLogout = () => {
    localStorage.removeItem("loggedInUser");
    setLoggedInUser(null);
  };

  return (
    <nav>
      {loggedInUser ? (
        <>
            <Link to="/">Home</Link>
          <Link to="/users">Users</Link>
          <Link to="/repositories">Repositories</Link>
          <Link to="/annotations">Annotations</Link>
          <button onClick={handleLogout}>Logout</button>
        </>
      ) : (
        <>
          <Link to="/login">Login</Link>
          <Link to="/register">Register</Link>
        </>
      )}
    </nav>
  );
};
