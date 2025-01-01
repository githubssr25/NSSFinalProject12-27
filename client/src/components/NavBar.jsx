import { Link } from "react-router-dom";

/* eslint-disable react/prop-types */
export const NavBar = ({ loggedInUser, setLoggedInUser }) => {
  const handleLogout = () => {
    localStorage.removeItem("loggedInUser");
    setLoggedInUser(null);
  };

  const userId = loggedInUser.id;

  return (
    <nav>
      {loggedInUser ? (
        <>
            <Link to="/">Home</Link>
          <Link to="/users">Users</Link>
          <Link to="/repositories"> View All Saved Repositories</Link>
          <Link to="/repositories/create">Create A New Repository</Link>
          <Link to="/annotations">View All Your Annotations</Link>
          <Link to="/annotations/add">Create A New Annotation</Link>
          <Link to={`/repositories/user/${userId}`}> Get Your Saved Repositories</Link>



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
