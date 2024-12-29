const BASE_URL = "http://localhost:5201/api/annotation";

// Fetch annotations by user
export const getAnnotationsByUser = async (userId) => {
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

// Fetch annotations by repository
export const getAnnotationsByRepository = async (repositoryId) => {
  try {
    const response = await fetch(`${BASE_URL}/repository/${repositoryId}`, {
      method: "GET",
    });

    if (!response.ok) {
      throw new Error(`Error fetching annotations: ${response.statusText}`);
    }

    return await response.json();
  } catch (error) {
    console.error("Error fetching annotations by repository:", error);
    throw error;
  }
};



