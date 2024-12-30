const BASE_URL = "http://localhost:5201/api/annotation";


export const getAnnotationById = async (annotationId) => {
    try {
      const response = await fetch(`${BASE_URL}/${annotationId}`, {
        method: "GET",
      });
  
      if (!response.ok) {
        throw new Error(`Error fetching annotation by ID: ${response.statusText}`);
      }
  
      return await response.json();
    } catch (error) {
      console.error("Error fetching annotation by ID:", error);
      throw error;
    }
  };

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

export const editAnnotation = async (annotationId, updatedAnnotation) => {
  try {
    const response = await fetch(`${BASE_URL}/${annotationId}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(updatedAnnotation),
    });

    if (!response.ok) {
      throw new Error(`Error editing annotation: ${response.statusText}`);
    }

    return await response.json();
  } catch (error) {
    console.error("Error editing annotation:", error);
    throw error;
  }
};

export const deleteAnnotation = async (annotationId) => {
  try {
    const response = await fetch(`${BASE_URL}/${annotationId}`, {
      method: "DELETE",
    });

    if (!response.ok) {
      throw new Error(`Error deleting annotation: ${response.statusText}`);
    }

    return await response.json();
  } catch (error) {
    console.error("Error deleting annotation:", error);
    throw error;
  }
};



