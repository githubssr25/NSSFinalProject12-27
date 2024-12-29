
using Microsoft.AspNetCore.Mvc;
using NSSFinalProject12_27.Context;
using NSSFinalProject.Models.DTOs;

namespace NSSFinalProject12_27.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnnotationController : ControllerBase
    {
        private readonly NSSFinalProjectDbContext _dbContext;

        public AnnotationController(NSSFinalProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get all annotations for a user
        [HttpGet("user/{userId}")]
        public IActionResult GetAnnotationsByUser(string userId)
        {
            var annotations = _dbContext.Annotations
                .Where(a => a.UserId == userId)
                .Select(a => new AnnotationDTO
                {
                    AnnotationId = a.AnnotationId,
                    RepositoryId = a.RepositoryId,
                    RepositoryName = a.Repository.RepositoryName,
                    Type = a.Type,
                    Content = a.Content,
                    CreatedAt = a.CreatedAt
                })
                .ToList();

            return Ok(annotations);
        }

        // Get annotations for a specific repository
        [HttpGet("repository/{repositoryId}")]
        public IActionResult GetAnnotationsByRepository(int repositoryId)
        {
            var annotations = _dbContext.Annotations
                .Where(a => a.RepositoryId == repositoryId)
                .Select(a => new AnnotationDTO
                {
                    AnnotationId = a.AnnotationId,
                    RepositoryId = a.RepositoryId,
                    RepositoryName = a.Repository.RepositoryName,
                    Type = a.Type,
                    Content = a.Content,
                    CreatedAt = a.CreatedAt
                })
                .ToList();

            return Ok(annotations);
        }

    }

}