namespace NSSFinalProject.Models.DTOs;

public class UpdateAnnotationDTO
{
    public int AnnotationId { get; set; } // Primary Key of the Annotation
    public int RepositoryId { get; set; } // Updated Repository association
    public string Type { get; set; } // Updated Annotation type (e.g., Note, Tag)
    public string Content { get; set; } // Updated Annotation content
}
