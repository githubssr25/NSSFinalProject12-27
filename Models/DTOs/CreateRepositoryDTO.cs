namespace NSSFinalProject.Models.DTOs;

    public class CreateRepositoryDTO
    {

        public int UserId { get; set;}
        public string RepositoryName { get; set; }
        public string RepositoryUrl { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int Stars { get; set; }
        public int CategoryId { get; set; } // Include CategoryDTO instead of raw fields
    }

