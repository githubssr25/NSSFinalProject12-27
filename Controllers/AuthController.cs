using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSSFinalProject12_27.Context;
using NSSFinalProject.Models;
using NSSFinalProject.Models.DTOs;
using System.Security.Claims;
using System.Text;

namespace NSSFinalProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly NSSFinalProjectDbContext _dbContext;
        private readonly UserManager<User> _userManager;

        public AuthController(NSSFinalProjectDbContext dbContext, UserManager<User> userManager)
        {
             Console.WriteLine("AuthController instantiated.");
             Console.WriteLine($"DbContext: {dbContext != null}, UserManager: {userManager != null}");
            _dbContext = dbContext;
            _userManager = userManager;
        }

        // Login Endpoint
[HttpPost("login")]
public async Task<IActionResult> Login([FromBody] LoginDTO loginDto)
{
    try
    {
        if (string.IsNullOrWhiteSpace(loginDto.Email) || string.IsNullOrWhiteSpace(loginDto.Password))
        {
            Console.WriteLine("Email or password is missing.");
            return BadRequest("Email and password are required.");
        }

        Console.WriteLine($"Attempting login for Email: {loginDto.Email}");

        var user = await _userManager.FindByEmailAsync(loginDto.Email);
        if (user == null)
        {
            Console.WriteLine($"User not found: {loginDto.Email}");
            return Unauthorized("Invalid credentials.");
        }

        Console.WriteLine($"User found: {user.UserName}. Verifying password.");

        var result = _userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, loginDto.Password);
        if (result != PasswordVerificationResult.Success)
        {
            Console.WriteLine($"Password verification failed for user: {loginDto.Email}");
            return Unauthorized("Invalid credentials.");
        }

        Console.WriteLine($"Password verified for user: {user.UserName}");

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.UserName)
        };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity));

        Console.WriteLine($"User {user.UserName} logged in successfully.");
        return Ok(new
        {
            id = user.Id,
            email = user.Email,
            userName = user.UserName,
            firstName = user.FirstName,
            lastName = user.LastName
        });
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error during login: {ex.Message}");
        return StatusCode(500, "Internal server error.");
    }
}



        // Logout Endpoint
        [HttpPost("logout")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok("Logout successful.");
        }



        [HttpPost("register")]
        public async Task<IActionResult> Register(RegistrationDTO registration)
        {
            try
            {
             // Fetch all IDs and filter numeric ones in memory
        var userIds = _dbContext.Users
            .Select(u => u.Id) // Select all IDs from the database
            .ToList()          // Bring them into memory
            .Where(id => id.All(char.IsDigit)) // Filter numeric IDs
            .Select(int.Parse) // Parse them to integers
            .OrderByDescending(id => id); // Get the highest one

        // Get the highest numeric userId or default to 0
        var highestUserId = userIds.FirstOrDefault();

        // Increment and assign the new userId
        var newUserId = (highestUserId + 1).ToString();

                var user = new User
                {
                    Id = newUserId, // Set the custom userId
                    UserName = registration.UserName,
                    Email = registration.Email,
                    FirstName = registration.FirstName,
                    LastName = registration.LastName,
                    EmailConfirmed = true // Assume email is confirmed for simplicity
                };

                Console.WriteLine($"Attempting registration for {registration.Email} with userId {newUserId}");

                var result = await _userManager.CreateAsync(user, registration.Password);
                if (!result.Succeeded)
                {
                    Console.WriteLine($"Registration failed for {registration.Email}: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                    return BadRequest(result.Errors);
                }

                Console.WriteLine($"Registration successful for {registration.Email}");

                // Automatically log the user in after registration
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.UserName)
        };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return Ok(new
                {
                    id = user.Id,
                    email = user.Email,
                    userName = user.UserName,
                    firstName = user.FirstName,
                    lastName = user.LastName
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during registration: {ex.Message}");
                return StatusCode(500, "Internal server error.");
            }
        }



        // Me Endpoint
        [HttpGet("me")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult Me()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == userId);

            if (user == null)
                return NotFound("User not found.");

            var userDto = new UserDTO
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            return Ok(userDto);
        }
    }
}
