
namespace NSSFinalProject.Models;

public class Repository {

    public int RepositoryId { get; set;}

    public string RepositoryName { get; set;} = "";

    public string RepositoryUrl { get; set;} = "";

    public string Description { get; set; }
    public string Language { get; set; }
    public int Stars { get; set; }
    public int? CategoryId { get; set; } // Foreign Ke

    public string? CreatorUserId { get; set; }

    // Navigation Properties
    public Category Category { get; set; }
    public ICollection<UserRepository> UserRepositories { get; set; }
    public ICollection<Annotation> Annotations { get; set; }


}



// Table Repositories {
//     repoId integer [primary key] // Unique identifier for each repository
//     repoName varchar
//     repoURL varchar
//     description text
//     language varchar
//     stars integer
//     categoryId integer
// }