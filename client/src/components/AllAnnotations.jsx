
import { useState, useEffect } from "react";
import { getAnnotationsByUser } from "../manager/annotationsManager";
import { Link } from "react-router-dom";

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
            <h5 className="card-title">
              Repository Name: {annotation.repositoryName}
            </h5>
            <p className="card-text">
              Annotation Id: {annotation.annotationId}
            </p>
            <p className="card-text">Content: {annotation.content}</p>
            <p className="card-text">Type: {annotation.type}</p>
            <p className="card-text">
              <small className="text-muted">
                Created At: {new Date(annotation.createdAt).toLocaleString()}
              </small>
            </p>
          </div>
          <Link
            to={`/annotations/edit/${annotation.annotationId}`}
            className="btn btn-primary mx-2"
          >
            Edit
          </Link>
          <Link
            to={`/annotations/delete/${annotation.annotationId}`}
            className="btn btn-danger mx-2"
          >
            Delete
          </Link>
        </div>
      ))}
    </div>
  );
};
