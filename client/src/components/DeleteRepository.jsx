import { useParams, useNavigate } from "react-router-dom";
import { deleteRepository } from "../manager/repositoryManager";



export const DeleteRepository = () => {

    const { repositoryId } = useParams(); // Get the repositoryId from the URL
    console.log("what is repositoryId", repositoryId);
    const navigate = useNavigate();
  
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