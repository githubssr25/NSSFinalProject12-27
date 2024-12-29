using Microsoft.AspNetCore.Mvc;
using NSSFinalProject12_27.Context;
using NSSFinalProject.Models.DTOs;

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
    }
}
