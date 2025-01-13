import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { register } from "../manager/authManager";
import { Button, FormGroup, Input, Label } from "reactstrap";
import "./Register.css";

const Register = ({ setLoggedInUser }) => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [userName, setUserName] = useState("");
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [error, setError] = useState("");
  const navigate = useNavigate();

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const user = await register(email, password, userName, firstName, lastName);
      console.log("Registration successful:", user);
      localStorage.setItem("loggedInUser", JSON.stringify(user));
      setLoggedInUser(user);
      navigate("/");
    } catch (err) {
      console.error("Registration failed:", err);
      setError("Registration failed. Please try again.");
    }
  };

  return (
    <div className="container">
      <h3>Register</h3>
      <form onSubmit={handleSubmit}>
        {error && <p className="text-danger">{error}</p>}
        <FormGroup>
          <Label>User Name</Label>
          <Input
            type="text"
            value={userName}
            onChange={(e) => setUserName(e.target.value)}
            required
          />
        </FormGroup>
        <FormGroup>
          <Label>Email</Label>
          <Input
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
          />
        </FormGroup>
        <FormGroup>
          <Label>Password</Label>
          <Input
            type="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
          />
        </FormGroup>
        <FormGroup>
          <Label>First Name</Label>
          <Input
            type="text"
            value={firstName}
            onChange={(e) => setFirstName(e.target.value)}
            required
          />
        </FormGroup>
        <FormGroup>
          <Label>Last Name</Label>
          <Input
            type="text"
            value={lastName}
            onChange={(e) => setLastName(e.target.value)}
            required
          />
        </FormGroup>
        <Button>Register</Button>
      </form>
    </div>
  );
};

export default Register;
