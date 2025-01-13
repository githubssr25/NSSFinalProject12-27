import { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { getRepositoryById, updateRepository } from "../manager/repositoryManager";
import { getAllCategories } from "../manager/categoryManager";
// import "./EditRepository.css";

/* eslint-disable react/prop-types */
export const EditRepository = ({ loggedInUser }) => {
  const { repositoryId } = useParams();
  const userId = loggedInUser.id;
  const navigate = useNavigate();
  const [formData, setFormData] = useState({
    repositoryName: "",
    repositoryUrl: "",
    description: "",
    language: "",
    stars: "",
    categoryId: null,
  });
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    // Fetch the repository data by ID
    getRepositoryById(repositoryId)
      .then((repo) => {
        setFormData({
          repositoryName: repo.repositoryName,
          repositoryUrl: repo.repositoryUrl,
          description: repo.description || "",
          language: repo.language || "",
          stars: repo.stars || 0,
          categoryId: repo.category?.categoryId || null,
        });
      })
      .catch((error) => console.error("Error fetching repository:", error));

    // Fetch all categories
    getAllCategories()
      .then(setCategories)
      .catch((error) => console.error("Error fetching categories:", error));
  }, [repositoryId]);

  const handleChangeForm = (e) => {
    const { name, value } = e.target;
    setFormData((form) => ({
      ...form,
      [name]: value,
    }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    const updatedRepositoryDto = {
      ...formData,
      stars: parseInt(formData.stars, 10) || 0,
      categoryId: formData.categoryId ? parseInt(formData.categoryId, 10) : null,
    };

    try {
      await updateRepository(repositoryId, updatedRepositoryDto);
      alert("Repository updated successfully!");
      navigate(`/repositories/user/${userId}`);
    } catch (error) {
      console.error("Error updating repository:", error);
      alert("Failed to update repository. Please try again.");
    }
  };

  return (
    <div className="container">
      <h3>Edit Repository</h3>
      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label>Repository Name</label>
          <input
            type="text"
            name="repositoryName"
            value={formData.repositoryName}
            onChange={handleChangeForm}
            required
            className="form-control"
          />
        </div>
        <div className="form-group">
          <label>Repository URL</label>
          <input
            type="url"
            name="repositoryUrl"
            value={formData.repositoryUrl}
            onChange={handleChangeForm}
            required
            className="form-control"
          />
        </div>
        <div className="form-group">
          <label>Description</label>
          <textarea
            name="description"
            value={formData.description}
            onChange={handleChangeForm}
            className="form-control"
          ></textarea>
        </div>
        <div className="form-group">
          <label>Language</label>
          <input
            type="text"
            name="language"
            value={formData.language}
            onChange={handleChangeForm}
            className="form-control"
          />
        </div>
        <div className="form-group">
          <label>Stars</label>
          <input
            type="number"
            name="stars"
            value={formData.stars}
            onChange={handleChangeForm}
            min="0"
            max="5"
            className="form-control"
          />
        </div>
        <div className="form-group">
          <label>Category</label>
          <select
            name="categoryId"
            value={formData.categoryId || ""}
            onChange={handleChangeForm}
            className="form-control"
          >
            <option value="">Select a Category</option>
            {categories.map((category) => (
              <option key={category.categoryId} value={category.categoryId}>
                {category.description}
              </option>
            ))}
          </select>
        </div>
        <button type="submit" className="btn btn-primary mt-3">
          Save Changes
        </button>
      </form>
    </div>
  );
};
