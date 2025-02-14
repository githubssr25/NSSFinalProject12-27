const _apiUrl = "http://localhost:5201/api/auth";

// Login method
export const login = async (email, password) => {
  try {
    const response = await fetch(_apiUrl + "/login", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ email, password }),
    });

    if (!response.ok) {
      throw new Error(`Login failed: ${response.statusText}`);
    }
    const user = await response.json();
    console.log("Successfully logged in user:", user); // Add this log
    return user;
  } catch (error) {
    console.error("Error during login:", error);
    throw error;
  }
};

// Logout method
export const logout = async () => {
  try {
    const response = await fetch(_apiUrl + "/logout", { method: "POST" });

    if (!response.ok) {
      throw new Error(`Logout failed: ${response.statusText}`);
    }

    return "Logout successful.";
  } catch (error) {
    console.error("Error during logout:", error);
    throw error;
  }
};

// Register method
export const register = async (email, password, userName, firstName, lastName) => {
  const _apiUrl = "http://localhost:5201/api/auth/register";
  try {
    const response = await fetch(_apiUrl, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({
        email,
        password,
        userName,
        firstName,
        lastName,
      }),
    });

    if (!response.ok) {
      throw new Error(`Registration failed: ${response.statusText}`);
    }

    const user = await response.json();
    console.log("Successfully registered user:", user);
    return user;
  } catch (error) {
    console.error("Error during registration:", error);
    throw error;
  }
};



// Get User by ID method
export const getUserById = async (id) => {
  try {
    const response = await fetch(`${_apiUrl}/${id}`, {
      method: "GET",
    });

    if (!response.ok) {
      throw new Error(`Failed to fetch user: ${response.statusText}`);
    }

    return await response.json(); // User data
  } catch (error) {
    console.error("Error fetching user by ID:", error);
    throw error;
  }
};
