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
    public class UserController: ControllerBase
    {
        private readonly NSSFinalProjectDbContext _dbContext;

        public UserController(NSSFinalProjectDbContext dbContext){

            _dbContext = dbContext;
        }

        [HttpGet]
          // Get All Users (Public Access)
        public IActionResult GetAllUsers()
        {
            var users = _dbContext.Users
                .Select(user => new UserDTO
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                }).ToList();

            return Ok(users);
        }

            // Get User by ID (Public Access)
        [HttpGet("{id}")]
        public IActionResult GetUserById(string id)
        {
            var user = _dbContext.Users
                .Where(u => u.Id == id)
                .Select(user => new UserDTO
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                })
                .FirstOrDefault();

            if (user == null)
                return NotFound("User not found.");

            return Ok(user);
        }

    
    }

}