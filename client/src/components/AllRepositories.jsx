import { useEffect, useState } from "react";
import { getAllRepositories, getRepositoriesByUserId, saveRepository } from "../manager/repositoryManager";
import "./AllRepositories.css";

/* eslint-disable react/prop-types */
export const AllRepositories = ({ loggedInUser }) => {
  const [repositories, setRepositories] = useState([]);
  const [userRepositories, setUserRepositories] = useState([]);
  const userId = loggedInUser.id;
  const [successMessage, setSuccessMessage] = useState("");
  const [shouldRefreshUserRepos, setShouldRefreshUserRepos] = useState(false); // Boolean trigger for user repositorie
  const [notYourRepos, setNotYourRepos] = useState([]);

  console.log("what is loggedinUser", loggedInUser);

  //   useEffect(() => {
  //     getAllRepositories().then(setRepositories).catch(console.error);
  //   }, []);
  useEffect(() => {
    const fetchAllRepositories = async () => {
      try {
        const allRepos = await getAllRepositories();
        setRepositories(allRepos);
      } catch (error) {
        console.error("Error fetching all repositories:", error);
      }
    };

    fetchAllRepositories();
  }, []);

  // Fetch user-specific repositories when the userId changes
  useEffect(() => {
    const fetchUserRepositories = async () => {
      try {
        const userRepos = await getRepositoriesByUserId(userId);
        setUserRepositories(userRepos);
      } catch (error) {
        console.error("Error fetching user repositories:", error);
      }
    };

    fetchUserRepositories(); // Fetch user-specific repositories
  }, [shouldRefreshUserRepos, userId]);

  useEffect(() => {
    const updatedNotYourRepos = repositories.filter((repo) => {
      //some is like Any we just want to know true or false if it exists and find which repos arent ours those are the ones with button
      const toIncludeOrNot = userRepositories.some(
        (eachUser) => eachUser.repositoryId == repo.repositoryId
      );
      if (toIncludeOrNot) {
        // If the repository is already in userRepositories, exclude it
        return false;
      } else {
        // If the repository is not in userRepositories, include it
        return true;
      }
    });
    setNotYourRepos(updatedNotYourRepos);
  }, [repositories, userRepositories]);

  const markAsOwnAnnotation = async (repositoryId) => {
    try {
      const response = await saveRepository(repositoryId, userId);
      console.log("Response from savedRepository:", response);

      // Set the success message with the repository name
      setSuccessMessage(
        `Repository '${response.savedRepository.repositoryId}' saved successfully!`
      );

      // Trigger a refresh for user repositories
      setShouldRefreshUserRepos(true);

      // Refresh the repositories list this may not be necessary idk
      const updatedRepositories = await getAllRepositories();
      setRepositories(updatedRepositories);
    } catch (error) {
      alert("Failed to save repository. Please try again.");
      console.error("Error saving repository:", error);
    }
  };

  return (
    <div className="repositories-container">
      <h2>All Repositories</h2>

      {/* Display success message */}
      {successMessage && (
        <div className="alert alert-success">{successMessage}</div>
      )}

      <ul className="repositories-list">
        {repositories.map((repo, index) => (
          <li key={index}>
            <a
              href={repo.repositoryUrl}
              target="_blank"
              rel="noopener noreferrer"
            >
              {repo.repositoryName}
            </a>
            <p>{repo.description}</p>
            <p>
              {repo.language} - {repo.stars} Stars
            </p>
            {repo.category && <p>Category: {repo.category.description}</p>}
            <div className="card-footer text-center">
              {/* Show button only if the repository is in `notYourRepos`If some() returns true:
The condition notYourRepos.some(...) evaluates to true.
The && operator passes control to the second part, rendering the <button>. 
The method notYourRepos.some((notRepo) => notRepo.repositoryId === repo.repositoryId) checks if any element 
in the notYourRepos array satisfies the condition notRepo.repositoryId === repo.repositoryId. It returns:
true if at least one element in notYourRepos matches the condition.*/}
              {notYourRepos.some(
                (notRepo) => notRepo.repositoryId === repo.repositoryId) && (
                <button
                  className="btn btn-danger mx-2"
                  onClick={() => markAsOwnAnnotation(repo.repositoryId)}
                >
                  Click To Save This A Repository For Your Account
                </button>
              )}
            </div>
          </li>
        ))}
      </ul>
    </div>
  );
};
