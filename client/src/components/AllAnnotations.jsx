
import { useState, useEffect } from "react";
import { getAnnotationsByUser } from "../manager/annotationsManager";
import { Link } from "react-router-dom";
import "./AllAnnotations.css";


/* eslint-disable react/prop-types */
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
      <h2 className="text-center">Your Annotations</h2>
      <div className="row">
        {annotations.map((annotation) => (
          <div key={annotation.annotationId} className="card">
            <div className="card-body">
              <h5 className="card-title">
                Repository Name: {annotation.repositoryName}
              </h5>
              <p className="card-text">Annotation Id: {annotation.annotationId}</p>
              <p className="card-text">Content: {annotation.content}</p>
              <p className="card-text">Type: {annotation.type}</p>
              <p className="card-text">
                <small className="text-muted">
                  Created At: {new Date(annotation.createdAt).toLocaleString()}
                </small>
              </p>
            </div>
            <div className="card-footer">
              <Link
                to={`/annotations/edit/${annotation.annotationId}`}
                className="btn btn-primary"
              >
                Edit
              </Link>
              <Link
                to={`/annotations/delete/${annotation.annotationId}`}
                className="btn btn-danger"
              >
                Delete
              </Link>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
};