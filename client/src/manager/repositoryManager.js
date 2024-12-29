const BASE_URL = "http://localhost:5201/api/repository";

// Fetch all repositories
export const getAllRepositories = async () => {
  try {
    const response = await fetch(`${BASE_URL}`, {
      method: "GET",
    });

    if (!response.ok) {
      throw new Error(`Error fetching repositories: ${response.statusText}`);
    }

    return await response.json();
  } catch (error) {
    console.error("Error fetching repositories:", error);
    throw error;
  }
};

// Fetch repositories by userId
export const getRepositoriesByUserId = async (userId) => {
  try {
    const response = await fetch(`${BASE_URL}/user/${userId}`, {
      method: "GET",
    });

    if (!response.ok) {
      throw new Error(`Error fetching repositories for user: ${response.statusText}`);
    }

    return await response.json();
  } catch (error) {
    console.error(`Error fetching repositories for user with ID ${userId}:`, error);
    throw error;
  }
};

export const getAnnotationsByUser = async (userId) => {
  // const BASE_URL = "http://localhost:5201/api/annotation";

  try {
    const response = await fetch(`${BASE_URL}/user/${userId}`, {
      method: "GET",
    });

    if (!response.ok) {
      throw new Error(`Error fetching annotations: ${response.statusText}`);
    }

    return await response.json();
  } catch (error) {
    console.error("Error fetching annotations by user:", error);
    throw error;
  }
};