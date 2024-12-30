using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSSFinalProject12_27.Context;
using NSSFinalProject.Models;
using NSSFinalProject.Models.DTOs;
using System.Security.Claims;

namespace NSSFinalProject12_27.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController: ControllerBase
    {
        private readonly NSSFinalProjectDbContext _dbContext;

        public CategoryController(NSSFinalProjectDbContext dbContext){

            _dbContext = dbContext;
        }

    [HttpGet]
    public IActionResult GetCategories()
    {
        var categories = _dbContext.Categories
            .Select(c => new CategoryDTO
            {
                CategoryId = c.CategoryId,
                Description = c.Description
            })
            .ToList();

        return Ok(categories);
    }


    }

}