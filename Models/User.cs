using Microsoft.AspNetCore.Identity;

namespace NSSFinalProject.Models;

public class User: IdentityUser

{

    public string? FirstName { get; set; }
    public string? LastName { get; set; }

       // Navigation Properties
    public ICollection<UserRepository> UserRepositories { get; set; }
    public ICollection<Annotation> Annotations { get; set; }


}