import { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { getAnnotationById, editAnnotation } from "../manager/annotationsManager";
import { getRepositoriesByUserId } from "../manager/repositoryManager";


/* eslint-disable react/prop-types */
export const EditAnnotation = ({ loggedInUser }) => {

    const { annotationId } = useParams();
    const navigate = useNavigate();
    const types = [ "Note", "Tag"];
    // const [annotations, setAnnotation] = useState(null);
    const [repositories, setRepositories] = useState([]);
    const [formData, setFormData] = useState({
        content: "",
        repositoryId: null,
        type: ""
      });
    
      useEffect(() => {
        // Fetch the annotation data
        getAnnotationById(annotationId)
          .then((data) => {
            setAnnotation(data);
            setFormData({ content: data.content, repositoryId: data.repositoryId, type: data.type});
          })
          .catch((error) => console.error("Error fetching annotation:", error));
    
        // Fetch repositories for the logged-in user
        getRepositoriesByUserId(parseInt(loggedInUser.id))
          .then(setRepositories)
          .catch((error) => console.error("Error fetching repositories:", error));
      }, [annotationId, loggedInUser.id]);


const handleInputChange = (e) => {
const {name, value} = e.target;

setFormData((form) => ({
  ...form,
  [name] : value,
}))
};


const handleSubmit = async (e) => {
e.prevent.default();

const updatedAnnotationDTO = {
  AnnotationId : annotationId,
  RepositoryId: formData.repositoryId,
  Type: formData.type,
  Content: formData.content
};

const response = editAnnotation(annotationId, updatedAnnotationDTO);

console.log("our response", response);

if(response){

  setFormData({
     content: "",
     repositoryId: null,
     type: ""
  });

  navigate("/annotations"); // Redirect after saving changes
}

};


      return (
        <div className="container">
          <h2>Edit Annotation</h2>
          <form onSubmit={handleSubmit}>
            <div className="form-group">
              <label htmlFor="content">Content</label>
              <textarea
                id="content"
                name="content"
                value={formData.content}
                onChange={handleInputChange}
                className="form-control"
                required
              ></textarea>
            </div>
            <div className="form-group">
              <label htmlFor="repositoryId">Change Associated Repository</label>
              <select
                id="repositoryId"
                name="repositoryId"
                value={formData.repositoryId || ""}
                onChange={handleInputChange}
                className="form-control"
                required
              >
                <option value="" disabled>Select a Repository</option>
                {repositories.map((repo) => (
                  <option key={repo.repositoryId} value={repo.repositoryId}>
                    {repo.repositoryName}
                  </option>
                ))}
              </select>
            </div>
            <div className="form-group">
              <label htmlFor="type"> Select Type</label>
              <select 
              id="type"
              name="type"
              value={formData.type}
              onChange={handleInputChange}
              className="form-control"
              required
              >
              <option value= "" disabled>
                Select A Type
              </option>
              {types.map((type, index) => (
                <option key={index} value={type}>
                  {type}
                </option>

              ))}
              </select>
            </div>
            <button type="submit" className="btn btn-primary mt-3">
              Save Changes
            </button>
          </form>
        </div>
      );
    };