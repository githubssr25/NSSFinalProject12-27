import { Route, Routes } from "react-router-dom";
import AuthorizedRoute from "./AuthorizedRoute";
import {Login} from "./components/Login";
import Register from "./components/Register";
import Home from "./components/Home";
import {AllUsers} from "./components/AllUsers"
/* eslint-disable react/prop-types */
export const ApplicationViews = ({loggedInUser, setLoggedInUser}) => {
return (
  <Routes>
    <Route path="/">
      <Route 
      index
      element={
        <AuthorizedRoute loggedInUser={loggedInUser}>
          <Home />
        </AuthorizedRoute>
      }
      />
         <Route
          path="login"
          element={<Login setLoggedInUser={setLoggedInUser} />}
        />
        <Route
          path="register"
          element={<Register setLoggedInUser={setLoggedInUser} />}
        />
      </Route>

      <Route path="users">
        <Route
        index
        element={
          <AuthorizedRoute loggedInUser={loggedInUser}>
            <AllUsers loggedInUser={loggedInUser} />
          </AuthorizedRoute>
        }

        />


      </Route>

  </Routes>


)}