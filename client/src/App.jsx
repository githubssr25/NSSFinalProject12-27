import { useEffect, useState } from "react";
import "./App.css";
import "bootstrap/dist/css/bootstrap.min.css";
import { getUserById } from "./manager/userManager";
import { Spinner } from "reactstrap";
// import {NavBar} from "./components/NavBar";
import {ApplicationViews} from "./ApplicationViews";

function App() {
  const [loggedInUser, setLoggedInUser] = useState();

  useEffect(() => {
    const storedUser = localStorage.getItem("loggedInUser");
    console.log("Found logged-in user in storage:", storedUser)
    if (storedUser) {
      setLoggedInUser(JSON.parse(storedUser));
    } else {
      // Replace `tryGetLoggedInUser` with `getUserById` logic
      const storedUserId = localStorage.getItem("loggedInUserId"); // Store ID separately
      if (storedUserId) {
        getUserById(storedUserId).then((user) => {
          if (user) {
            localStorage.setItem("loggedInUser", JSON.stringify(user));
            setLoggedInUser(user);
          }
        });
      } else {
        setLoggedInUser(null); // No user logged in
      }
    }
  }, []);

  if (loggedInUser === undefined) {
    return <Spinner />;
  }

  return (
    <>
      {/* <NavBar loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} /> */}
      <ApplicationViews
        loggedInUser={loggedInUser}
        setLoggedInUser={setLoggedInUser}
      />
    </>
  );
}

export default App;
