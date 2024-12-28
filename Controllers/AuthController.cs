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
            _dbContext = dbContext;
            _userManager = userManager;
        }

        // Login Endpoint
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromHeader(Name = "Authorization")] string authHeader)
        {
            if (string.IsNullOrWhiteSpace(authHeader) || !authHeader.StartsWith("Basic "))
                return Unauthorized("Invalid Authorization header.");

            string encodedCreds = authHeader.Substring(6).Trim();
            string creds = Encoding.GetEncoding("iso-8859-1").GetString(Convert.FromBase64String(encodedCreds));

            int separator = creds.IndexOf(':');
            if (separator == -1)
                return Unauthorized("Invalid credentials format.");

            string email = creds.Substring(0, separator);
            string password = creds.Substring(separator + 1);

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return Unauthorized("Invalid credentials.");

            var result = _userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
            if (result != PasswordVerificationResult.Success)
                return Unauthorized("Invalid credentials.");

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

            return Ok("Login successful.");
        }

        // Logout Endpoint
        [HttpPost("logout")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok("Logout successful.");
        }

        // Register Endpoint
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegistrationDTO registration)
        {
            var user = new User
            {
                UserName = registration.UserName,
                Email = registration.Email,
                FirstName = registration.FirstName,
                LastName = registration.LastName,
                EmailConfirmed = true // For simplicity, assume emails are confirmed
            };

            var result = await _userManager.CreateAsync(user, registration.Password);
            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("Registration successful.");
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
