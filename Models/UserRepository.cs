namespace NSSFinalProject.Models;

public class UserRepository
{
     public string UserId { get; set; } // Foreign Key (now string)
    public int RepositoryId { get; set; } // Foreign Key
    public DateTime SavedAt { get; set; }

    // Navigation Properties
    public User User { get; set; }
    public Repository Repository { get; set; }
}