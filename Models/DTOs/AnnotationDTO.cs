namespace NSSFinalProject.Models.DTOs;

public class AnnotationDTO
    {
        public int AnnotationId { get; set; }
        public int RepositoryId { get; set; } // Foreign Key for Repository
        public string RepositoryName { get; set; } // To display repository name
        public string Type { get; set; } // Annotation type (e.g., Note, Tag)
        public string Content { get; set; } // Actual annotation content
        public DateTime CreatedAt { get; set; } // Timestamp for annotation creation
    }