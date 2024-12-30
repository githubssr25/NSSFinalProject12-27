using Microsoft.AspNetCore.Mvc;
using NSSFinalProject12_27.Context;
using NSSFinalProject.Models.DTOs;
using NSSFinalProject.Models;

namespace NSSFinalProject12_27.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepositoryController : ControllerBase
    {
        private readonly NSSFinalProjectDbContext _dbContext;

        public RepositoryController(NSSFinalProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get all repositories
        [HttpGet]
        public IActionResult GetAllRepositories()
        {
            var repositories = _dbContext.Repositories
                .Select(repo => new RepositoryDTO
                {
                    RepositoryId = repo.RepositoryId,
                    RepositoryName = repo.RepositoryName,
                    RepositoryUrl = repo.RepositoryUrl,
                    Description = repo.Description,
                    Language = repo.Language,
                    Stars = repo.Stars,
                    Category = repo.Category == null ? null : new CategoryDTO
                    {
                        CategoryId = repo.Category.CategoryId,
                        Description = repo.Category.Description
                    }
                })
                .ToList();

            return Ok(repositories);
        }

        // Get repositories by userId
        [HttpGet("user/{userId}")]
        public IActionResult GetRepositoriesByUserId(string userId)
        {
            var userRepositories = _dbContext.UserRepositories
                .Where(ur => ur.UserId == userId)
                .Select(ur => ur.Repository)
                .Select(repo => new RepositoryDTO
                {
                    RepositoryId = repo.RepositoryId,
                    RepositoryName = repo.RepositoryName,
                    RepositoryUrl = repo.RepositoryUrl,
                    Description = repo.Description,
                    Language = repo.Language,
                    Stars = repo.Stars,
                    Category = repo.Category == null ? null : new CategoryDTO
                    {
                        CategoryId = repo.Category.CategoryId,
                        Description = repo.Category.Description
                    }
                })
                .ToList();

            return Ok(userRepositories);
        }




//    const userIdAsInt = parseInt(userId, 10); REMEMBER TO INCLUDE THIS ON FRONT END 
        [HttpPost]
        public IActionResult CreateRepository([FromBody] CreateRepositoryDTO createRepositoryDTO){

              // Check if the repository already exists in the database
    var existingRepository = _dbContext.Repositories
        .FirstOrDefault(r => r.RepositoryId == createRepositoryDTO.RepositoryId);

        if(existingRepository == null){ 

         var newRepository =  new Repository {
            RepositoryName = createRepositoryDTO.RepositoryName,
            RepositoryUrl = createRepositoryDTO.RepositoryUrl,
            Description = createRepositoryDTO.Description,
            Language = createRepositoryDTO.Language,
            Stars = createRepositoryDTO.Stars,
            CategoryId = createRepositoryDTO.CategoryId,
            UserRepositories = new List<UserRepository> {}
         };

         // Add the new repository to the database
    _dbContext.Repositories.Add(newRepository);
    _dbContext.SaveChanges(); // This generates the RepositoryId for the new repository

     
    // _dbContext.UserRepositories.Add(userRepositoryJoin);
    //You only need to add the Repository entity with the associated UserRepository entry. EF Core will cascade and handle the UserRepository insertion automatically.

// Use the newly generated RepositoryId for the join table
    var userRepositoryJoin = new UserRepository
    {
        UserId = createRepositoryDTO.UserId.ToString(),
        RepositoryId = newRepository.RepositoryId, // Use the ID from the saved repository
        SavedAt = DateTime.UtcNow
    };

    // Add the join entry to the UserRepositories table
    _dbContext.UserRepositories.Add(userRepositoryJoin);
    _dbContext.SaveChanges();
 return Ok(newRepository);

        } else {
            var existingUserRepositoryJoin = _dbContext.UserRepositories.FirstOrDefault(ur => ur.RepositoryId == createRepositoryDTO.RepositoryId && ur.UserId == createRepositoryDTO.UserId.ToString());
            if (existingUserRepositoryJoin != null)
        {
            return BadRequest("User is already associated with this repository.");
        }

            var userRepositoryJoin = new UserRepository {
            UserId = createRepositoryDTO.UserId.ToString(),
            RepositoryId = createRepositoryDTO.RepositoryId,
            SavedAt = DateTime.UtcNow
            };
            _dbContext.UserRepositories.Add(userRepositoryJoin);
            // existingRepository.UserRepositories.Add(userRepositoryJoin);
             _dbContext.SaveChanges();
             return Ok(userRepositoryJoin);
            }
}}


// public class UserRepository{
//      public string UserId { get; set; } // Foreign Key (now string)
//     public int RepositoryId { get; set; } // Foreign Key
//     public DateTime SavedAt { get; set; }

//     public User User { get; set; }
//     public Repository Repository { get; set; } }


    // public class CreateRepositoryDTO
    // {
    //     public int RepositoryId { get; set; }
    //     public int UserId { get; set;}
    //     public string RepositoryName { get; set; }
    //     public string RepositoryUrl { get; set; }
    //     public string Description { get; set; }
    //     public string Language { get; set; }
    //     public int Stars { get; set; }
    //     public CategoryId { get; set; } // Include CategoryDTO instead of raw fields
    // }


// public class Repository {

//     public int RepositoryId { get; set;}
//     public string RepositoryName { get; set;} = "";
//     public string RepositoryUrl { get; set;} = "";
//     public string Description { get; set; }
//     public string Language { get; set; }
//     public int Stars { get; set; }
//     public int? CategoryId { get; set; } // Foreign Ke

//     public Category Category { get; set; }
//     public ICollection<UserRepository> UserRepositories { get; set; }
//     public ICollection<Annotation> Annotations { get; set; }






    }

