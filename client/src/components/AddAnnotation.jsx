import { useState, useEffect } from "react";
import { createAnnotation } from "../manager/annotationsManager";
import { getRepositoriesByUserId } from "../manager/repositoryManager";
import "./AddAnnotation.css";

/* eslint-disable react/prop-types */
export const AddAnnotation = ({loggedInUser}) => {
    const [repositories, setRepositories] = useState([]);
    const [formData, setFormData] = useState({
      repositoryId: null,
      type: "",
      content: "",
    });
    const types = ["Note", "Tag"]; // Hardcoded types

useEffect(() => {
    getRepositoriesByUserId(loggedInUser.id)
    .then((data) => {
        console.log("Fetched repositories:", data); 
            setRepositories(data);
    })
    .catch((error) => console.error("error fetching repositories:", error));
}, [loggedInUser.id])




const handleInputChange = (e) => {
const {name, value} = e.target;
setFormData((formData) => ({
    ...formData,
    [name] : value
}));
};

const handleSubmit = async (e) => {
e.preventDefault();

const createAnnotationDTO = {
    RepositoryId : parseInt(formData.repositoryId, 10),
    UserId : String(loggedInUser.id),
    Type : formData.type,
    Content: formData.content
};

console.log("Payload sent to server:", createAnnotationDTO);


const response = await createAnnotation(createAnnotationDTO);

console.log("this is response from creatingAnnotationDTO", response);

if(response){
    console.log("Annotation created successfully:", response);
    setFormData({ repositoryId: null, type: "", content: "" });
}};





return (
<>
<div className="container">
    <h3> Add New Annotation To Saved Repository</h3>
    <form onSubmit={handleSubmit} >
        <div className="form-group">
            <label htmlFor="repositoryId"> Choose Repository This New Annotation Will Be Added To </label>
            <select 
            id="repositoryId"
            name="repositoryId"
            value={formData.repositoryId || ""}
            onChange={handleInputChange}
            className="form-control"
            required
            >
                <option value="">
                    Select a Repository 
                </option>
                {repositories.map((eachRepo, index) => (
                    <option key={index} value={eachRepo.repositoryId} >
                      Repository Name: {eachRepo.repositoryName}
                    </option>
                ))}
            </select>
        </div>
        <div className="form-group">
            <label htmlFor="type"> Choose Type of Annotation </label>
            <select
            id="type"
            name="type"
            value={formData.type || ""}
            onChange={handleInputChange}
            className="form-control"
            required
          >
            <option> 
                Choose Either Note Or Tag 
            </option>
            {types.map((eachType, index) => (
                <option key={index} value={eachType}>
                    {eachType}
                </option>

            ))}
        </select>
        </div>
        <div className="form-group">
            <label> Enter Content For Annotation </label>
            <input
            type="text"
            name="content"
            value={formData.content}
            onChange={handleInputChange}
            required
            />
        </div>
        <button type="submit" className="btn-add-annotation">
            Click to Add Annotation
        </button>
    </form>
</div>

</>
)
}