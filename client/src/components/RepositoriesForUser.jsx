import { useEffect, useState } from "react";
import { getRepositoriesByUserId } from "../manager/repositoryManager";
import { useParams } from "react-router-dom";

/* eslint-disable react/prop-types */
export const RepositoriesForUser = ({ loggedInUser }) => {
  const { userId } = useParams(); // Get the userId from the route
  const [repositories, setRepositories] = useState([]);

  useEffect(() => {
    if (loggedInUser) {
      getRepositoriesByUserId(userId)
        .then((data) => {
          console.log("Fetched repositories for user:", data); // Log fetched data
          setRepositories(data); // Update the state with the fetched repositories
        })
        .catch((error) => {
          console.error("Error fetching repositories for user:", error); // Log any errors
        });
    }
  }, [loggedInUser]);

  return (
    <div>
      <h2>Repositories for {loggedInUser?.firstName || "User"}</h2>
      <ul>
        {repositories.map((repo, index) => (
          <li key={index}>
            <a href={repo.repositoryUrl} target="_blank" rel="noopener noreferrer">
              {repo.repositoryName}
            </a>
            <p>{repo.description}</p>
            <p>{repo.language} - {repo.stars} Stars</p>
            {repo.category && <p>Category: {repo.category.description}</p>}
          </li>
        ))}
      </ul>
    </div>
  );
};