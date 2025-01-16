import { useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
import {  getRepositoryById, deleteRepository, removeUserFromRepository } from "../manager/repositoryManager";

/* eslint-disable react/prop-types */
export const DeleteRepository = ({ loggedInUser }) => {

  const userId = loggedInUser.id;
  console.log("what is userId", userId);

    const { repositoryId } = useParams(); // Get the repositoryId from the URL
    console.log("what is repositoryId", repositoryId);
    const navigate = useNavigate();
    const [repository, setRepository] = useState(null);
    const [isCreator, setIsCreator] = useState(false);
  

    useEffect(() => {
      const fetchRepository = async () => {
        try {
          const repo = await getRepositoryById(repositoryId);
          setRepository(repo);
          console.log("what is repo value", repo);
          console.log("what is value of repo create user and loggedInUserId", repo.createUserId, userId);

            // Determine if the logged-in user is the creator of the repository
        if (repo.createUserId === userId) {
          setIsCreator(true);
        }
        } catch (error) {
          console.error("Error fetching repository:", error);
        }


      };
  
      fetchRepository();
    }, [repositoryId, navigate]);





    const handleDelete = async () => {
      try {
        if (isCreator) {
          // If the user is the creator, delete the repository entirely
          await deleteRepository(parseInt(repositoryId));
          alert("Repository deleted successfully!");
        } else {
          // If the user is not the creator, remove them from the repository
          await removeUserFromRepository(loggedInUser.id, parseInt(repositoryId));
          alert("Removed repository from your account successfully!");
        }
  
        navigate("/repositories"); // Redirect to the repositories list
      } catch (error) {
        alert("Error processing repository deletion. Please try again.");
        console.error("Error deleting or removing repository:", error);
      }
    };



    return (
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
          {isCreator ? "Yes, Delete Repository" : "Yes, Remove From My Account"}
        </button>
        <button
          className="btn btn-secondary mx-2"
          onClick={() => navigate("/repositories")}
        >
          Cancel
        </button>
      </div>
    );
  };