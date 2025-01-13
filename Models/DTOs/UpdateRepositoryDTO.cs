namespace NSSFinalProject.Models.DTOs
{
    public class UpdateRepositoryDTO
    {
        public string RepositoryName { get; set; } // Required
        public string RepositoryUrl { get; set; } // Required
        public string Description { get; set; } // Optional
        public string Language { get; set; } // Optional
        public int Stars { get; set; } // Optional
        public int? CategoryId { get; set; } // Nullable
    }
}
