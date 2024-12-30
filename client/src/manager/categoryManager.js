const CATEGORY_BASE_URL = "http://localhost:5201/api/category";

export const getAllCategories = async () => {
  try {
    const response = await fetch(`${CATEGORY_BASE_URL}`);
    if (!response.ok) {
      throw new Error(`Error fetching categories: ${response.statusText}`);
    }
    return await response.json();
  } catch (error) {
    console.error("Error fetching categories:", error);
    throw error;
  }
};
