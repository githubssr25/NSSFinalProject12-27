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



export const createNewRepository = async (createRepositoryDto) => {
try {
  // Ensure userId is converted to an integer
  const response = await fetch(`${BASE_URL}`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(createRepositoryDto),
  });

  return await response.json();
} catch (error) {
  console.error("Error creating/associating repository", error);
}
};

export const deleteRepository = async (repositoryId) => {
  try {
    const response = await fetch(`${BASE_URL}/${repositoryId}`, {
      method: "DELETE",
    });

    if (!response.ok) {
      throw new Error(`Error deleting repository: ${response.statusText}`);
    }

    return true; // Return success flag
  } catch (error) {
    console.error("Error deleting repository:", error);
    throw error;
  }
};

export const updateRepository = async (repositoryId, updateRepositoryDto) => {
  try {
    const response = await fetch(`${BASE_URL}/${repositoryId}`, {
      method: "PUT", // Use PUT for updating
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(updateRepositoryDto), // Pass updated repository details
    });

    if (!response.ok) {
      throw new Error(`Error updating repository: ${response.statusText}`);
    }

    return await response.json(); // Return updated repository details
  } catch (error) {
    console.error("Error updating repository:", error);
    throw error;
  }
};

export const getRepositoryById = async (repositoryId) => {
  try {
    const response = await fetch(`${BASE_URL}/${repositoryId}`, {
      method: "GET",
    });
    if (!response.ok) {
      throw new Error(`Error fetching repository: ${response.statusText}`);
    }
    return await response.json();
  } catch (error) {
    console.error("Error fetching repository:", error);
    throw error;
  }
};

export const saveRepository = async(repositoryId, userId) => {
try {

  console.log(`Request URL: ${BASE_URL}/${repositoryId}/save?userId=${userId}`);
  console.log(`Type of userId: ${typeof userId}`);

  const response = await fetch(`${BASE_URL}/${repositoryId}/save?userId=${userId}`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
  });

  if (!response.ok){
    throw new Error(`Error saving repository: ${response.statusText}`);
  }
  // Correctly call response.json()
  const responseData = await response.json();
  console.log("Response data from saveRepository:", responseData);

  return responseData;


} catch(error){
  console.error("Error saving repository", error);
  throw error;
}

};


export const removeUserFromRepository = async (userId, repositoryId) => {
  try {
    const response = await fetch(`${BASE_URL}/user/${userId}/repository/${repositoryId}`, {
      method: "DELETE",
    });

    if (!response.ok) {
      const errorMessage = await response.text();
      throw new Error(errorMessage || "Failed to remove user from repository.");
    }

    const result = await response.json();
console.log(result.message); // Log the message
return result;

  } catch (error) {
    console.error("Error removing user from repository:", error);
    throw error;
  }
};













