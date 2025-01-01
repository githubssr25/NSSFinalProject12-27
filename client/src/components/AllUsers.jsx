import { useEffect, useState } from "react";
import { getAllUsers } from "../manager/UserManager"; // Import your UserManager method
import "./AllUsers.css";

export const AllUsers = () => {

    const [users, setUsers] = useState([]);


 useEffect(() => {
    const fetchUsers = async () => {
      try {
        const data = await getAllUsers();
        console.log("structureo f users data in all users", data);
        setUsers(data);
      } catch (err) {
        console.error("Error fetching users:", err);
      } 
    };
    fetchUsers();
  }, []);



  return (
    <div className="all-users">
      <h2 className="users-header">All Users</h2>
      {users.length === 0 ? (
        <p>No users found.</p>
      ) : (
        <ul className="user-list">
          {users.map((user) => (
            <li key={user.id}>
              <strong>{user.userName}</strong> ({user.email})<br />
              Name: {user.firstName} {user.lastName}
            </li>
          ))}
        </ul>
      )}
    </div>
  );
};