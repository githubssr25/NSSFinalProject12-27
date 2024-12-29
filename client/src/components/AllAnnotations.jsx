
import { useState, useEffect } from "react";
import { getAnnotationsByUser } from "../manager/repositoryManager";

export const AllAnnotations = ({ loggedInUser }) => {
  const [annotations, setAnnotations] = useState([]);
  console.log("what is loggedinUser", loggedInUser);

  useEffect(() => {
    if (loggedInUser) {
      getAnnotationsByUser(loggedInUser.id)
        .then((data) => {
          console.log("Fetched annotations:", data); // Log the fetched annotations
          setAnnotations(data); // Set the annotations state
        })
        .catch((error) => {
          console.error("Error fetching annotations:", error); // Log any errors
        });
    }
  }, [loggedInUser]);
  

  return (
    <div className="container">
      <h2>Your Annotations</h2>
      {annotations.map((annotation) => (
        <div key={annotation.annotationId} className="card my-2">
          <div className="card-body">
          <h5 className="card-title"> Repository Name {annotation.repositoryName}</h5>
            <h5 className="card-title"> Category {annotation.category.description}</h5>
            <p className="card-text"> Description{annotation.description}</p>
            <p className="card-text"> Repository URL{annotation.repositoryUrl}</p>
            <p className="card-text"> Stars{annotation.stars}</p>
            <p className="card-text">
              <small className="text-muted">Created At: {annotation.CreatedAt}</small>
            </p>
          </div>
        </div>
      ))}
    </div>
  );
};
