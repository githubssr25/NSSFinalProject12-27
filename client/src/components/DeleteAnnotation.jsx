import { useParams, useNavigate } from "react-router-dom";
import { deleteAnnotation } from "../manager/annotationsManager";
import "./DeleteAnnotation.css";


export const DeleteAnnotation = () => {
    const { annotationId } = useParams();
    const navigate = useNavigate();
  
    const handleDelete = async () => {
      try {
        await deleteAnnotation(annotationId);
        navigate("/annotations");
      } catch (error) {
        console.error("Error deleting annotation:", error);
      }
    };
  
    return (
      <div className="container">
        <h2>Are you sure you want to delete this annotation?</h2>
        <button onClick={handleDelete} className="btn btn-danger mx-2">
          Yes, Delete
        </button>
        <button onClick={() => navigate("/annotations")} className="btn btn-secondary mx-2">
          Cancel
        </button>
      </div>
    );
  };