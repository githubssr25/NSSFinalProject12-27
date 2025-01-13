import { useState, useEffect } from "react";
import { createNewRepository } from "../manager/repositoryManager";
import { getAllCategories } from "../manager/categoryManager";
import "./CreateRepository.css";

/* eslint-disable react/prop-types */
export const CreateRepository = ({loggedInUser}) => {
    const [categories, setCategories] = useState([]);
    const [formData, setFormData] = useState({
        repositoryName: "",
        repositoryUrl: "",
        description: "",
        language: "",
        stars: "",
        categoryId: null,
    });

    const [successMessage, setSuccessMessage] = useState(""); // State for success message

    useEffect(() => {
        // Fetch categories from the backend
        getAllCategories()
          .then(setCategories)
          .catch((error) => {
            console.error(error);
          });
      }, []);


const handleChangeForm = (e) => {
const {name, value} = e.target;

setFormData((form) => ({
    ...form,
    [name]: value,
}));
}
const handleSubmit = async (e) => {
  e.preventDefault();

  const createRepositoryDto = {
      repositoryName: formData.repositoryName, // Required
      repositoryUrl: formData.repositoryUrl,   // Required
      description: formData.description || null, // Optional
      language: formData.language || null,     // Optional
      stars: parseInt(formData.stars, 10) || 0, // Default to 0 if not provided
      categoryId: formData.categoryId ? parseInt(formData.categoryId, 10) : null, // Null if not selected
      userId: parseInt(loggedInUser.id, 10)    // Required
  };

  console.log("Payload sent to backend:", createRepositoryDto);

  try {
    const ourResponse = await createNewRepository(createRepositoryDto);
    if (ourResponse) {
        console.log("Successfully created new repository", ourResponse);
        // Display success message with repository name
        setSuccessMessage(`Successfully created repository: ${ourResponse.repositoryName}`);

        // Clear the form
        setFormData({
            repositoryName: "",
            repositoryUrl: "",
            description: "",
            language: "",
            stars: "",
            categoryId: null,
        });
    }
} catch (error) {
    console.error("Error creating repository:", error);
    alert("Failed to create repository. Please check the input fields and try again.");
}
};




return (
<div className="container">
    <h3> Create A New Repository </h3>
    {successMessage && <div className="alert alert-success mt-3">{successMessage}</div>}
    <form onSubmit={handleSubmit}>
        <div className="form-group">
            <label> Make a Repository Name</label>
            <input 
            type = "text"
            name = "repositoryName"
            value={formData.repositoryName}
            onChange={handleChangeForm}
            required
            />
        </div>
        <div className="form-group">
          <label htmlFor="repositoryUrl">Repository URL</label>
          <input
            type="url"
            className="form-control"
            id="repositoryUrl"
            name="repositoryUrl"
            value={formData.repositoryUrl}
            onChange={handleChangeForm}
            required
          />
        </div>
        <div className="form-group">
          <label htmlFor="description">Description</label>
          <textarea
            className="form-control"
            id="description"
            name="description"
            value={formData.description}
            onChange={handleChangeForm}
          />
        </div>
        <div className="form-group">
          <label htmlFor="language">Language</label>
          <input
            type="text"
            className="form-control"
            id="language"
            name="language"
            value={formData.language}
            onChange={handleChangeForm}
          />
        </div>
        <div className="form-group">
          <label htmlFor="stars">Stars</label>
          <input
            type="number"
            className="form-control"
            id="stars"
            name="stars"
            value={formData.stars}
            onChange={handleChangeForm}
            min="1"
            max="5"
          />
        </div>
       
        <div className="form-group">
            <label htmlFor="categoryId"> Category </label>
            <select
            className="form-control"
            id="categoryId"  //The value of the selected <option> is passed to the <select> element's value attribute.
            // The onChange handler (handleInputChange) is triggered, capturing the name and value of the <select> element.
            name="categoryId"
            value={formData.categoryId || ""}
            onChange={handleChangeForm}
            >
                <option value="" >
                    Select a Category
                </option>
                {categories.map((category) => (
                    <option key={category.categoryId} value ={category.categoryId}>
                        {category.description}
                    </option>
                ))}
            </select>
        </div>

        <button type="submit" className="btn btn-primary mt-3">
          Create Repository
        </button>

    </form>
</div>
)}