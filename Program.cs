using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using NSSFinalProject12_27.Context;
using NSSFinalProject.Models;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers().AddJsonOptions(opts =>
{
    opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// Configure CORS to allow the frontend to communicate with the backend
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policyBuilder =>
    {
        policyBuilder.WithOrigins("http://localhost:5173") // Replace with your frontend's URL
                     .AllowAnyHeader()
                     .AllowAnyMethod();
    });
});

builder.Services.AddAutoMapper(typeof(Program));



// Add Identity services for authentication
builder.Services.AddIdentityCore<User>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 8;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<NSSFinalProjectDbContext>() // Ensure this matches your DbContext class
.AddDefaultTokenProviders(); // Add default token providers for password reset and more

// Configure the database connection (PostgreSQL in this case)
builder.Services.AddNpgsql<NSSFinalProjectDbContext>(builder.Configuration["ConnectionStrings:NSSFinalProject12-27Db"]);

// Configure cookie-based authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.Cookie.Name = "NSSFinalProjectCookie";
        options.Cookie.SameSite = SameSiteMode.Strict;
        options.Cookie.HttpOnly = true;
         options.Cookie.MaxAge = TimeSpan.FromDays(7);
        options.SlidingExpiration = true;
        options.ExpireTimeSpan = TimeSpan.FromHours(24);
        options.Events.OnRedirectToLogin = (context) =>
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            return Task.CompletedTask;
        };
        options.Events.OnRedirectToAccessDenied = (context) =>
        {
            context.Response.StatusCode = StatusCodes.Status403Forbidden;
            return Task.CompletedTask;
        };
    });

// Add Swagger for API documentation (for development purposes)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(); // Enable CORS
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication(); // Enable authentication
app.UseAuthorization(); // Enable authorization
app.MapControllers(); // Map API controllers
app.Run();
