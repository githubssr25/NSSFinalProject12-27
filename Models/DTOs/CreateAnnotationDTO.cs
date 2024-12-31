namespace NSSFinalProject.Models.DTOs;

public class CreateAnnotationDTO
{
    public int RepositoryId { get; set; } // Repository to associate the annotation with
    public string UserId { get; set; } // User who creates the annotation
    public string Type { get; set; } // Type of annotation: "Note" or "Tag"
    public string Content { get; set; } // Annotation content
}
