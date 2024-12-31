import { Route, Routes, Outlet } from "react-router-dom";
import AuthorizedRoute from "./AuthorizedRoute";
import {Login} from "./components/Login";
import Register from "./components/Register";
import {Home} from "./components/Home";
import {AllUsers} from "./components/AllUsers"
import {AllRepositories} from "./components/AllRepositories";
import {AllAnnotations} from "./components/AllAnnotations";
import {CreateRepository} from "./components/CreateRepository";
import {EditAnnotation} from "./components/EditAnnotation";
import {DeleteAnnotation} from "./components/DeleteAnnotation";
import {AddAnnotation} from "./components/AddAnnotation";
import {NavBar} from "./components/NavBar";

/* eslint-disable react/prop-types */
export const ApplicationViews = ({loggedInUser, setLoggedInUser}) => {

return (
<Routes>
   {/* Non-Authorized Routes */}
   <Route path="login" element={<Login setLoggedInUser={setLoggedInUser} />} />
  <Route path="register" element={<Register setLoggedInUser={setLoggedInUser} />} />

  {/* Authorized Routes */ }
  <Route
  path="/"
  element={
    <AuthorizedRoute loggedInUser={loggedInUser}>
      <>
         <NavBar loggedInUser={loggedInUser} setLoggedInUser={setLoggedInUser} />
         <Outlet /> {/* This is the crucial addition */}
      </>
    </AuthorizedRoute>
  }
  > {/* The path="/" route is a top-level route that acts as the parent for all other routes (like /users, /repositories, /annotations). */ }
{/*The index route is treated as a child route of this parent. It is not directly part of the element because React Router expects the element to define the layout, not the content. */}
{/* Why Can’t index Be Part of element?
The element in path="/" is only for rendering a layout or wrapper component (e.g., AuthorizedRoute + NavBar). 
The actual content for / must be defined separately as the index route.

How Does React Router Know / Maps to <Home />?
When a user visits /, React Router checks for an index route nested under the route with path="/".
If an index route exists, React Router renders the element of the index route (<Home /> in this case).
The path="/" route’s element (i.e., <AuthorizedRoute> and <NavBar>) acts as a shared layout for all child routes, including the index route.
A route with path="/" is the parent route. All other routes nested inside it (defined in its element) are its child routes.
*/} 
 
 
  {/* Index Route */}
  <Route index element={ <> {console.log("Rendering Home")} <Home /> </> } />

   {/* Users Group */}
   <Route path="users">
          <Route
            index
            element={
              <>
                {console.log("Rendering Users")}
                <AllUsers loggedInUser={loggedInUser} />
              </>
            }
          />
        </Route>
  
  {/* Repositories Group */}
     {/* Repositories Group */}
     <Route path="repositories">
          <Route index element={<AllRepositories loggedInUser={loggedInUser} />} />
          <Route path="create" element={<CreateRepository loggedInUser={loggedInUser} />} />
        </Route>

  {/*Annotations Group */}
  <Route path="annotations">
    <Route index element ={<AllAnnotations loggedInUser={loggedInUser} />} />
    <Route path="edit/:annotationId" element={<EditAnnotation loggedInUser={loggedInUser} />} />
    <Route path="delete/:annotationId" element={<DeleteAnnotation loggedInUser={loggedInUser} />} />
    <Route path="add" element={<AddAnnotation loggedInUser={loggedInUser} />} />
  </Route>

  </Route>
</Routes>

);
};















































//   return (
//   <Routes>
//     <Route path="/">
//       <Route
//         index
//         element={
//           <AuthorizedRoute loggedInUser={loggedInUser}>
//             <Home />
//           </AuthorizedRoute>
//         }
//       />
//       <Route
//         path="login"
//         element={<Login setLoggedInUser={setLoggedInUser} />}
//       />
//       <Route
//         path="register"
//         element={<Register setLoggedInUser={setLoggedInUser} />}
//       />
//     </Route>

//     <Route path="users">
//       <Route
//         index
//         element={
//           <AuthorizedRoute loggedInUser={loggedInUser}>
//             <AllUsers loggedInUser={loggedInUser} />
//           </AuthorizedRoute>
//         }
//       />
//     </Route>

//     <Route path="repositories">
//       <Route
//         index
//         element={
//           <AuthorizedRoute loggedInUser={loggedInUser}>
//             <AllRepositories loggedInUser={loggedInUser} />
//           </AuthorizedRoute>
//         }
//       />
//       <Route
//         path="create"
//         element={
//           <AuthorizedRoute loggedInUser={loggedInUser}>
//             <CreateRepository loggedInUser={loggedInUser} />
//           </AuthorizedRoute>
//         }
//       />
//     </Route>

//     <Route path="annotations">
//       <Route
//         index
//         element={
//           <AuthorizedRoute loggedInUser={loggedInUser}>
//             <AllAnnotations loggedInUser={loggedInUser} />
//           </AuthorizedRoute>
//         }
//       />
//       <Route 
//       path="edit/:annotationId"
//       element={
//         <AuthorizedRoute loggedInUser={loggedInUser}>
//           <EditAnnotation loggedInUser={loggedInUser} />
//         </AuthorizedRoute>
//       }
//       />
//       <Route 
//       path="delete/:annotationId"
//       element={
//         <AuthorizedRoute loggedInUser={loggedInUser}>
//           <DeleteAnnotation loggedInUser={loggedInUser}/>
//         </AuthorizedRoute>
//       }
//       />
//     </Route>
//   </Routes>
// );
