
using Microsoft.AspNetCore.Mvc;
using NSSFinalProject12_27.Context;
using NSSFinalProject.Models.DTOs;
using NSSFinalProject.Models;

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

        [HttpGet("{annotationId}")]
        public IActionResult GetAnnotationById(int annotationId)
        {
            var annotation = _dbContext.Annotations
            .Where(a => a.AnnotationId == annotationId)
            .Select(a => new AnnotationDTO
            {
                AnnotationId = a.AnnotationId,
                RepositoryId = a.RepositoryId,
                RepositoryName = _dbContext.Repositories.Where(eachRepo => eachRepo.RepositoryId == a.RepositoryId).Select(repo => repo.RepositoryName).FirstOrDefault(),
                Type = a.Type,
                Content = a.Content,
                CreatedAt = a.CreatedAt
            }).FirstOrDefault();

            if (annotation == null)
            {
                return NotFound($"Annotation with ID {annotationId} not found.");
            }

            return Ok(annotation);
        }

        [HttpPut("{annotationId}")]
        public IActionResult UpdateAnnotation(int annotationId, UpdateAnnotationDTO annotationDTO)
        {

            var annotation = _dbContext.Annotations.FirstOrDefault(a => a.AnnotationId == annotationId);

            if (annotation == null)
            {
                return NotFound("Annotation not found.");
            }

            annotation.RepositoryId = annotationDTO.RepositoryId;
            annotation.Type = annotationDTO.Type;
            annotation.Content = annotationDTO.Content;

            _dbContext.SaveChanges();

            return Ok(annotation);
        }

        [HttpPost]
public IActionResult CreateAnnotation([FromBody] CreateAnnotationDTO createAnnotationDTO)
{
    // Check if the repository exists
    var repository = _dbContext.Repositories.FirstOrDefault(r => r.RepositoryId == createAnnotationDTO.RepositoryId);
    if (repository == null)
    {
        return NotFound("Repository not found.");
    }

    // Create a new Annotation
    var annotation = new Annotation
    {
        RepositoryId = createAnnotationDTO.RepositoryId,
        UserId = createAnnotationDTO.UserId,
        Type = createAnnotationDTO.Type,
        Content = createAnnotationDTO.Content,
        CreatedAt = DateTime.UtcNow
    };

    _dbContext.Annotations.Add(annotation);
    _dbContext.SaveChanges();

    return Ok(annotation);
}






    }

}