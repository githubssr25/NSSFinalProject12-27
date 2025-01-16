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
                    CreateUserId = repo.CreatorUserId, // Added CreatorUserId
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
                    CreateUserId = repo.CreatorUserId,
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


            Console.WriteLine($"Received payload: {System.Text.Json.JsonSerializer.Serialize(createRepositoryDTO)}");

            if (createRepositoryDTO == null)
            {
                Console.WriteLine("createRepositoryDTO is null.");
                return BadRequest("Payload is invalid.");
            }

            Console.WriteLine($"RepositoryName: {createRepositoryDTO.RepositoryName}");
            Console.WriteLine($"UserId: {createRepositoryDTO.UserId}");


    // Check if a repository with the same name already exists
    var existingRepository = _dbContext.Repositories
        .FirstOrDefault(r => r.RepositoryName == createRepositoryDTO.RepositoryName);

    Repository repositoryToUse;

    if (existingRepository != null)
    {
        Console.WriteLine($"Repository with name '{createRepositoryDTO.RepositoryName}' already exists.");

        // Check if the user is already associated with this existing repository
        var existingUserRepositoryJoin = _dbContext.UserRepositories
            .FirstOrDefault(ur => ur.RepositoryId == existingRepository.RepositoryId
                                  && ur.UserId == createRepositoryDTO.UserId.ToString());
        if (existingUserRepositoryJoin != null)
        {
            Console.WriteLine($"User {createRepositoryDTO.UserId} is already associated with repository '{createRepositoryDTO.RepositoryName}'.");
            return BadRequest("User is already associated with this repository.");
        }

        repositoryToUse = existingRepository; // Use the existing repository
    }
    else
    {
        // Create a new repository
        repositoryToUse = new Repository
        {
            RepositoryName = createRepositoryDTO.RepositoryName,
            RepositoryUrl = createRepositoryDTO.RepositoryUrl,
            Description = createRepositoryDTO.Description,
            Language = createRepositoryDTO.Language,
            Stars = createRepositoryDTO.Stars,
            CreatorUserId = createRepositoryDTO.UserId,
            CategoryId = createRepositoryDTO.CategoryId, // Can be null
            UserRepositories = new List<UserRepository>() // Initialize navigation property
        };

        _dbContext.Repositories.Add(repositoryToUse);
        _dbContext.SaveChanges(); // Generates RepositoryId
        Console.WriteLine($"New repository '{repositoryToUse.RepositoryName}' created.");
    }

 // Add the user-repository join entry (only one join created)
    var userRepositoryJoin = new UserRepository
    {
        UserId = createRepositoryDTO.UserId.ToString(),
        RepositoryId = repositoryToUse.RepositoryId,
        SavedAt = DateTime.UtcNow
    };

    _dbContext.UserRepositories.Add(userRepositoryJoin);
    _dbContext.SaveChanges();

    Console.WriteLine($"User {createRepositoryDTO.UserId} associated with repository '{repositoryToUse.RepositoryName}'.");
    return Ok(new { repository = repositoryToUse, userRepositoryJoin });
}








// Delete a repository
[HttpDelete("{repositoryId}")]
public IActionResult DeleteRepository(int repositoryId)
{
    // Get the repository and include the associated UserRepositories
    var repository = _dbContext.Repositories
        .FirstOrDefault(r => r.RepositoryId == repositoryId);

    if (repository == null)
    {
        return NotFound("Repository not found.");
    }

// Load the associated UserRepositories explicitly
repository.UserRepositories = _dbContext.UserRepositories
    .Where(ur => ur.RepositoryId == repositoryId)
    .ToList();

    // Remove associated UserRepositories and the repository itself
    _dbContext.UserRepositories.RemoveRange(repository.UserRepositories);
    _dbContext.Repositories.Remove(repository);
    _dbContext.SaveChanges();

    return NoContent(); // Return 204 No Content
}


[HttpGet("{repositoryId}")]
public IActionResult GetRepositoryById(int repositoryId)
{
    // Fetch the repository by ID
    var repository = _dbContext.Repositories
        .Where(r => r.RepositoryId == repositoryId)
        .Select(r => new RepositoryDTO
        {
            RepositoryId = r.RepositoryId,
            CreateUserId = r.CreatorUserId, // Added CreatorUserId
            RepositoryName = r.RepositoryName,
            RepositoryUrl = r.RepositoryUrl,
            Description = r.Description,
            Language = r.Language,
            Stars = r.Stars,
            Category = r.Category == null ? null : new CategoryDTO
            {
                CategoryId = r.Category.CategoryId,
                Description = r.Category.Description
            }
        })
        .FirstOrDefault();

    if (repository == null)
    {
        // Return 404 if the repository is not found
        return NotFound($"Repository with ID {repositoryId} not found.");
    }

    // Return the repository details
    return Ok(repository);
}

[HttpPut("{repositoryId}")]
public IActionResult UpdateRepository(int repositoryId, [FromBody] UpdateRepositoryDTO updateRepositoryDto)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    var repository = _dbContext.Repositories.FirstOrDefault(r => r.RepositoryId == repositoryId);
    if (repository == null)
    {
        return NotFound($"Repository with ID {repositoryId} not found.");
    }

    // Update repository fields
    repository.RepositoryName = updateRepositoryDto.RepositoryName;
    repository.RepositoryUrl = updateRepositoryDto.RepositoryUrl;
    repository.Description = updateRepositoryDto.Description;
    repository.Language = updateRepositoryDto.Language;
    repository.Stars = updateRepositoryDto.Stars;
    repository.CategoryId = updateRepositoryDto.CategoryId;

    _dbContext.SaveChanges();

    return Ok(repository);
}



//Saves a repository for a specific user by creating a user-repository association.
[HttpPost("{repositoryId}/save")]
public IActionResult SaveRepository(int repositoryId, [FromQuery] string userId)
{
    // Log incoming parameters
    Console.WriteLine($"Incoming request to SaveRepository.");
    Console.WriteLine($"repositoryId: {repositoryId}, userId: {userId}");

    // Check if userId is null or empty
    if (string.IsNullOrWhiteSpace(userId))
    {
        Console.WriteLine("User ID is null or empty.");
        return BadRequest("User ID is required.");
    }

    // Log before querying the repository
    Console.WriteLine($"Checking if repository with ID {repositoryId} exists in the database.");
    var repository = _dbContext.Repositories.FirstOrDefault(r => r.RepositoryId == repositoryId);

    if (repository == null)
    {
        Console.WriteLine($"Repository with ID {repositoryId} not found.");
        return NotFound($"Repository with ID {repositoryId} not found.");
    }

    // Enhanced logging for user-repository relationship
    Console.WriteLine($"Query Inputs - userId: '{userId}', repositoryId: {repositoryId}");

    // Log all user-repository records for debugging
    var allUserRepositories = _dbContext.UserRepositories.ToList();
    Console.WriteLine("Current UserRepositories Table:");
    foreach (var record in allUserRepositories)
    {
        Console.WriteLine($"UserId: '{record.UserId}', RepositoryId: {record.RepositoryId}, SavedAt: {record.SavedAt}");
    }

    // Find potential matches for repositoryId
    var potentialMatches = _dbContext.UserRepositories
        .Where(ur => ur.RepositoryId == repositoryId)
        .ToList();
    Console.WriteLine($"Potential Matches for repositoryId {repositoryId}:");
    foreach (var match in potentialMatches)
    {
        Console.WriteLine($"UserId: '{match.UserId}', RepositoryId: {match.RepositoryId}");
    }

    // Check for an exact match
    var normalizedUserId = userId.Trim();
    var exactMatch = potentialMatches.FirstOrDefault(ur => ur.UserId.Trim() == normalizedUserId);

    if (exactMatch != null)
    {
        Console.WriteLine($"Exact match found for userId: '{userId}' and repositoryId: {repositoryId}");
        return BadRequest("Repository is already saved by the user.");
    }

    // Log before creating the user-repository join
    Console.WriteLine($"Creating a new user-repository association for userId: {userId}, repositoryId: {repositoryId}.");
    var userRepositoryJoin = new UserRepository
    {
        UserId = userId,
        RepositoryId = repository.RepositoryId,
        SavedAt = DateTime.UtcNow
    };

    try
    {
        // Save the user-repository association to the database
        _dbContext.UserRepositories.Add(userRepositoryJoin);
        _dbContext.SaveChanges();
        Console.WriteLine($"User {userId} successfully saved repository {repositoryId}.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving user-repository association: {ex.Message}");
        return StatusCode(500, "Internal server error.");
    }

    // Return a success response
    return Ok(new
    {
        message = "Repository saved successfully",
        savedRepository = userRepositoryJoin
    });
}


[HttpDelete("user/{userId}/repository/{repositoryId}")]
public IActionResult RemoveUserFromRepository(string userId, int repositoryId)
{
    var userRepository = _dbContext.UserRepositories
        .FirstOrDefault(ur => ur.UserId == userId && ur.RepositoryId == repositoryId);

    if (userRepository == null)
    {
        return NotFound("User-repository association not found.");
    }

    _dbContext.UserRepositories.Remove(userRepository);
    _dbContext.SaveChanges();

   return Ok(new { message = "User successfully removed from repository." });

}



}



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

