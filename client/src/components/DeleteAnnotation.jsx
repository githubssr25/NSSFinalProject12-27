import { useParams, useNavigate } from "react-router-dom";
import { useState, useEffect } from "react";
import { deleteAnnotation, getAnnotationById } from "../manager/annotationsManager";
import "./DeleteAnnotation.css";


export const DeleteAnnotation = () => {
  const { annotationId } = useParams();
  const navigate = useNavigate();
  const [annotation, setAnnotation] = useState(null);

  const handleDelete = async () => {
    try {
      await deleteAnnotation(annotationId);
      navigate("/annotations");
    } catch (error) {
      console.error("Error deleting annotation:", error);
    }
  };

  useEffect(() => {
    const fetchAnnotation = async () => {
      try {
        const annotationData = await getAnnotationById(annotationId);
        console.log("what is annotationData", annotationData);
        setAnnotation(annotationData);
      } catch (error) {
        console.error("Error fetching annotation:", error);
        alert("Error loading annotation details.");
        navigate("/annotations"); // Redirect if fetching fails
      }
    };

    fetchAnnotation();
  }, [annotationId, navigate]);

  return (
    <div className="container">
      <h2>Are you sure you want to delete this annotation?</h2>
      <div className="card-body">
        <p className="card-text">Annotation Id: {annotation?.annotationId}</p>
        <p className="card-text">Content: {annotation?.content}</p>
        <p className="card-text">Type: {annotation?.type}</p>
        <p className="card-text">
          <small className="text-muted">
            Created At:{" "}
            {annotation?.createdAt
              ? new Date(annotation.createdAt).toLocaleString()
              : "Loading..."}
          </small>
        </p>
      </div>
      <button onClick={handleDelete} className="btn btn-danger mx-2">
        Yes, Delete
      </button>
      <button
        onClick={() => navigate("/annotations")}
        className="btn btn-secondary mx-2"
      >
        Cancel
      </button>
    </div>
  );
};