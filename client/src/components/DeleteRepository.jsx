import { useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
import {  getRepositoryById, deleteRepository } from "../manager/repositoryManager";



export const DeleteRepository = () => {

    const { repositoryId } = useParams(); // Get the repositoryId from the URL
    console.log("what is repositoryId", repositoryId);
    const navigate = useNavigate();
    const [repository, setRepository] = useState(null);
  

    useEffect(() => {
      const fetchRepository = async () => {
        try {
          const repo = await getRepositoryById(repositoryId);
          setRepository(repo);
        } catch (error) {
          console.error("Error fetching repository:", error);
          alert("Error loading repository details.");
          navigate("/repositories"); // Redirect if fetching fails
        }
      };
  
      fetchRepository();
    }, [repositoryId, navigate]);





    const handleDelete = async () => {
      try {
        await deleteRepository(parseInt(repositoryId));
        alert("Repository deleted successfully!");
        navigate("/repositories"); // Redirect to the repositories list
      } catch (error) {
        alert("Error deleting repository. Please try again.");
        console.error("Error deleting repository:", error);
      }
    };



return (
<>
<div className="container">
      <h2>Are you sure you want to delete this repository?</h2>
      {repository && (
          <div>
            <p><strong>Repository Name:</strong> {repository.repositoryName}</p>
            <p><strong>Description:</strong> {repository.description}</p>
            <p><strong>Language:</strong> {repository.language}</p>
            <p><strong>Stars:</strong> {repository.stars}</p>
            {repository.category && (
              <p><strong>Category:</strong> {repository.category.description}</p>
            )}
          </div>
        )}
      <button
        className="btn btn-danger mx-2"
        onClick={handleDelete}
      >
        Yes, Delete
      </button>
      <button
        className="btn btn-secondary mx-2"
        onClick={() => navigate("/repositories")}
      >
        Cancel
      </button>
    </div>

</>
)
}