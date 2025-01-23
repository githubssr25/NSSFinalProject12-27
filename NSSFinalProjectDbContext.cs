using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NSSFinalProject.Models;
using Microsoft.AspNetCore.Identity;


namespace NSSFinalProject12_27.Context
{
    public class NSSFinalProjectDbContext : IdentityDbContext<User> // Use IdentityDbContext for built-in Identity support
    {
        private readonly IConfiguration _configuration;

        public NSSFinalProjectDbContext(DbContextOptions<NSSFinalProjectDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        // Define DbSets for custom entities
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<Annotation> Annotations { get; set; }
        public DbSet<UserRepository> UserRepositories { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
    {
        var connectionString = _configuration.GetConnectionString("NSSFinalProject12-27Db");
        optionsBuilder.UseNpgsql(connectionString);
    }
            // Enable detailed logging
  // Enable detailed logging for debugging purposes
            optionsBuilder
                .LogTo(Console.WriteLine, LogLevel.Information) // Logs EF Core commands
                .EnableSensitiveDataLogging()                  // Logs parameter values (careful with sensitive data!)
                .EnableDetailedErrors();                      // Provides detailed error messages
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Ensure Identity-related mappings are set up

            // var adminUser = new User
            // {
            //     Id = Guid.NewGuid().ToString(), // Generate unique GUID
            //     UserName = "admin",
            //     Email = "admin@example.com",
            //     NormalizedUserName = "ADMIN",
            //     NormalizedEmail = "ADMIN@EXAMPLE.COM",
            //     FirstName = "Admin",
            //     LastName = "User",
            //     EmailConfirmed = true
            // };
            // adminUser.PasswordHash = hasher.HashPassword(adminUser, "AdminPassword123!");

            // modelBuilder.Entity<User>().HasData(adminUser);
 var hasher = new PasswordHasher<User>();

    // Seed Users
    modelBuilder.Entity<User>().HasData(
        new User
        {
            Id = "1",
            UserName = "john_doe",
            Email = "john.doe@example.com",
            NormalizedUserName = "JOHN_DOE",
            NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
            FirstName = "John",
            LastName = "Doe",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        },
        new User
        {
            Id = "2",
            UserName = "jane_smith",
            Email = "jane.smith@example.com",
            NormalizedUserName = "JANE_SMITH",
            NormalizedEmail = "JANE.SMITH@EXAMPLE.COM",
            FirstName = "Jane",
            LastName = "Smith",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        },
        new User
        {
            Id = "3",
            UserName = "alice_brown",
            Email = "alice.brown@example.com",
            NormalizedUserName = "ALICE_BROWN",
            NormalizedEmail = "ALICE.BROWN@EXAMPLE.COM",
            FirstName = "Alice",
            LastName = "Brown",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        },
        new User
        {
            Id = "4",
            UserName = "bob_jones",
            Email = "bob.jones@example.com",
            NormalizedUserName = "BOB_JONES",
            NormalizedEmail = "BOB.JONES@EXAMPLE.COM",
            FirstName = "Bob",
            LastName = "Jones",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        },
        new User
        {
            Id = "5",
            UserName = "carla_white",
            Email = "carla.white@example.com",
            NormalizedUserName = "CARLA_WHITE",
            NormalizedEmail = "CARLA.WHITE@EXAMPLE.COM",
            FirstName = "Carla",
            LastName = "White",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        },
        new User
        {
            Id = "6",
            UserName = "michael_green",
            Email = "michael.green@example.com",
            NormalizedUserName = "MICHAEL_GREEN",
            NormalizedEmail = "MICHAEL.GREEN@EXAMPLE.COM",
            FirstName = "Michael",
            LastName = "Green",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        },
        new User
        {
            Id = "7",
            UserName = "linda_lee",
            Email = "linda.lee@example.com",
            NormalizedUserName = "LINDA_LEE",
            NormalizedEmail = "LINDA.LEE@EXAMPLE.COM",
            FirstName = "Linda",
            LastName = "Lee",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        },
        new User
        {
            Id = "8",
            UserName = "james_brown",
            Email = "james.brown@example.com",
            NormalizedUserName = "JAMES_BROWN",
            NormalizedEmail = "JAMES.BROWN@EXAMPLE.COM",
            FirstName = "James",
            LastName = "Brown",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        },
        new User
        {
            Id = "9",
            UserName = "emma_clark",
            Email = "emma.clark@example.com",
            NormalizedUserName = "EMMA_CLARK",
            NormalizedEmail = "EMMA.CLARK@EXAMPLE.COM",
            FirstName = "Emma",
            LastName = "Clark",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        },
        new User
        {
            Id = "10",
            UserName = "daniel_evans",
            Email = "daniel.evans@example.com",
            NormalizedUserName = "DANIEL_EVANS",
            NormalizedEmail = "DANIEL.EVANS@EXAMPLE.COM",
            FirstName = "Daniel",
            LastName = "Evans",
            EmailConfirmed = true,
            PasswordHash = hasher.HashPassword(null, "Password123!")
        }
    );

//     // Seed Categories
    modelBuilder.Entity<Category>().HasData(
        new Category { CategoryId = 1, Description = "Backend" },
        new Category { CategoryId = 2, Description = "Frontend" },
        new Category { CategoryId = 3, Description = "Artificial Intelligence" },
        new Category { CategoryId = 4, Description = "Full Stack" },
        new Category { CategoryId = 5, Description = "Data Science" },
        new Category { CategoryId = 6, Description = "Security" },
        new Category { CategoryId = 7, Description = "Testing" },
        new Category { CategoryId = 8, Description = "Machine Learning" },
        new Category { CategoryId = 9, Description = "Other" }
    );

// //     // Seed Repositories
modelBuilder.Entity<Repository>().HasData(
    new Repository
    {
        RepositoryId = 1,
        RepositoryName = "Backend Framework",
        RepositoryUrl = "https://github.com/example/backend-framework",
        Description = "A powerful backend framework for building scalable applications.",
        Language = "C#",
        Stars = 1200,
        CategoryId = 1,
        CreatorUserId = "1" // John Doe
    },
    new Repository
    {
        RepositoryId = 2,
        RepositoryName = "Frontend Library",
        RepositoryUrl = "https://github.com/example/frontend-library",
        Description = "A sleek and efficient frontend library.",
        Language = "JavaScript",
        Stars = 950,
        CategoryId = 2,
        CreatorUserId = "2" // Jane Smith
    },
    new Repository
    {
        RepositoryId = 3,
        RepositoryName = "AI Toolkit",
        RepositoryUrl = "https://github.com/example/ai-toolkit",
        Description = "A comprehensive toolkit for AI research.",
        Language = "Python",
        Stars = 2500,
        CategoryId = 3,
        CreatorUserId = "3" // Alice Brown
    },
    new Repository
    {
        RepositoryId = 4,
        RepositoryName = "Data Science Hub",
        RepositoryUrl = "https://github.com/example/data-science-hub",
        Description = "A hub of resources for data scientists.",
        Language = "R",
        Stars = 1800,
        CategoryId = 5,
        CreatorUserId = "4" // Bob Jones
    },
    new Repository
    {
        RepositoryId = 5,
        RepositoryName = "Testing Framework",
        RepositoryUrl = "https://github.com/example/testing-framework",
        Description = "An intuitive testing framework.",
        Language = "Java",
        Stars = 700,
        CategoryId = 7,
        CreatorUserId = "5" // Carla White
    },
    new Repository
    {
        RepositoryId = 6,
        RepositoryName = "Cyber Security Toolkit",
        RepositoryUrl = "https://github.com/example/security-toolkit",
        Description = "A comprehensive toolkit for cyber security.",
        Language = "Python",
        Stars = 1300,
        CategoryId = 6,
        CreatorUserId = "6" // Michael Green
    }
);


// Seed Repositories
modelBuilder.Entity<Repository>().HasData(
    new Repository
    {
        RepositoryId = 7,
        RepositoryName = "AI-Powered Threat Detection",
        RepositoryUrl = "https://github.com/example/ai-threat-detection",
        Description = "An AI-driven system to detect and prevent security threats.",
        Language = "Python",
        Stars = 1700,
        CategoryId = 6,
        CreatorUserId = "7" // Linda Lee
    },
    new Repository
    {
        RepositoryId = 8,
        RepositoryName = "Cloud Security Suite",
        RepositoryUrl = "https://github.com/example/cloud-security-suite",
        Description = "A suite of tools to secure cloud environments efficiently.",
        Language = "Go",
        Stars = 1900,
        CategoryId = 6,
        CreatorUserId = "8" // James Brown
    }, 
     new Repository
    {
        RepositoryId = 9,
        RepositoryName = "Web Scraper Pro",
        RepositoryUrl = "https://github.com/example/web-scraper-pro",
        Description = "A powerful web scraping tool with automation features.",
        Language = "JavaScript",
        Stars = 1500,
        CategoryId = 2,
        CreatorUserId = "9" // Emma Clark
    },
    new Repository
    {
        RepositoryId = 10,
        RepositoryName = "Machine Learning Sandbox",
        RepositoryUrl = "https://github.com/example/ml-sandbox",
        Description = "An interactive sandbox for machine learning models.",
        Language = "Python",
        Stars = 2000,
        CategoryId = 8,
        CreatorUserId = "10" // Daniel Evans
    },
    new Repository
    {
        RepositoryId = 11,
        RepositoryName = "Full Stack Starter Kit",
        RepositoryUrl = "https://github.com/example/full-stack-starter",
        Description = "A starter kit for full stack development projects.",
        Language = "TypeScript",
        Stars = 1500,
        CategoryId = 4,
        CreatorUserId = "2" 
    },
    new Repository
    {
        RepositoryId = 12,
        RepositoryName = "Data Visualization Library",
        RepositoryUrl = "https://github.com/example/data-visualization-lib",
        Description = "A library for creating stunning data visualizations.",
        Language = "JavaScript",
        Stars = 1400,
        CategoryId = 5,
        CreatorUserId = "4" 
    }
);


// Seed UserRepositories
modelBuilder.Entity<UserRepository>().HasData(
  
    new UserRepository { UserId = "1", RepositoryId = 1, SavedAt = DateTime.UtcNow },  // John Doe
    new UserRepository { UserId = "2", RepositoryId = 2, SavedAt = DateTime.UtcNow },  // Jane Smith
    new UserRepository { UserId = "3", RepositoryId = 3, SavedAt = DateTime.UtcNow },  // Alice Brown
    new UserRepository { UserId = "4", RepositoryId = 4, SavedAt = DateTime.UtcNow },  // Bob Jones
    new UserRepository { UserId = "5", RepositoryId = 5, SavedAt = DateTime.UtcNow },  // Carla White
    new UserRepository { UserId = "6", RepositoryId = 6, SavedAt = DateTime.UtcNow },  // Michael Green
    new UserRepository { UserId = "7", RepositoryId = 7, SavedAt = DateTime.UtcNow },   // Linda Lee
    new UserRepository { UserId = "8", RepositoryId = 8, SavedAt = DateTime.UtcNow },  // James Brown
    new UserRepository { UserId = "9", RepositoryId = 9, SavedAt = DateTime.UtcNow },  // Emma Clark
    new UserRepository { UserId = "10", RepositoryId = 10, SavedAt = DateTime.UtcNow }, // Daniel Evans
    new UserRepository { UserId = "2", RepositoryId = 11, SavedAt = DateTime.UtcNow },
    new UserRepository { UserId = "4", RepositoryId = 12, SavedAt = DateTime.UtcNow },
     // Additional users for repositories 3, 5, 6, 7, 8
    new UserRepository { UserId = "6", RepositoryId = 3, SavedAt = DateTime.UtcNow },  
    new UserRepository { UserId = "8", RepositoryId = 3, SavedAt = DateTime.UtcNow },  

    new UserRepository { UserId = "1", RepositoryId = 5, SavedAt = DateTime.UtcNow },  
    new UserRepository { UserId = "3", RepositoryId = 5, SavedAt = DateTime.UtcNow },  
    new UserRepository { UserId = "9", RepositoryId = 5, SavedAt = DateTime.UtcNow },  

    new UserRepository { UserId = "2", RepositoryId = 6, SavedAt = DateTime.UtcNow },  
    new UserRepository { UserId = "5", RepositoryId = 6, SavedAt = DateTime.UtcNow },  

    new UserRepository { UserId = "4", RepositoryId = 7, SavedAt = DateTime.UtcNow },  
    new UserRepository { UserId = "9", RepositoryId = 7, SavedAt = DateTime.UtcNow },  
    new UserRepository { UserId = "10", RepositoryId = 7, SavedAt = DateTime.UtcNow },  

    new UserRepository { UserId = "3", RepositoryId = 8, SavedAt = DateTime.UtcNow },  
    new UserRepository { UserId = "6", RepositoryId = 8, SavedAt = DateTime.UtcNow },  
    new UserRepository { UserId = "7", RepositoryId = 8, SavedAt = DateTime.UtcNow }  
);


// //     // Seed UserRepositories
// //  // Seed UserRepositories
// modelBuilder.Entity<UserRepository>().HasData(
//     new UserRepository { UserId = "1", RepositoryId = 1, SavedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc) },
//     new UserRepository { UserId = "2", RepositoryId = 2, SavedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc) },
//     new UserRepository { UserId = "3", RepositoryId = 3, SavedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc) },
//     new UserRepository { UserId = "4", RepositoryId = 4, SavedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc) },
//     new UserRepository { UserId = "5", RepositoryId = 5, SavedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc) }
// );



modelBuilder.Entity<Annotation>().HasData(
    new Annotation
    {
        AnnotationId = 1,
        UserId = "1",
        RepositoryId = 1,
        Type = "Note",
        Content = "This backend framework looks promising for my next project.",
        CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc)
    }
    // new Annotation
    // {
    //     AnnotationId = 2,
    //     UserId = "2",
    //     RepositoryId = 2,
    //     Type = "Note",
    //     Content = "Great library for frontend animations.",
    //     CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc)
    // },
    // new Annotation
    // {
    //     AnnotationId = 3,
    //     UserId = "3",
    //     RepositoryId = 3,
    //     Type = "Tag",
    //     Content = "AI",
    //     CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc)
    // },
    // new Annotation
    // {
    //     AnnotationId = 4,
    //     UserId = "4",
    //     RepositoryId = 4,
    //     Type = "Note",
    //     Content = "Data science repo with useful algorithms.",
    //     CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc)
    // }



// Seed Annotations
// modelBuilder.Entity<Annotation>().HasData(
//     new Annotation
//     {
//         AnnotationId = 6,
//         UserId = "7",
//         RepositoryId = 7,
//         Type = "Tag",
//         Content = "Automated Testing",
//         CreatedAt = DateTime.UtcNow
//     },
//     new Annotation
//     {
//         AnnotationId = 7,
//         UserId = "8",
//         RepositoryId = 8,
//         Type = "Note",
//         Content = "Great sandbox for testing ML algorithms.",
//         CreatedAt = DateTime.UtcNow
//     },
//     new Annotation
//     {
//         AnnotationId = 8,
//         UserId = "9",
//         RepositoryId = 9,
//         Type = "Tag",
//         Content = "Full Stack",
//         CreatedAt = DateTime.UtcNow
//     },
//     new Annotation
//     {
//         AnnotationId = 9,
//         UserId = "10",
//         RepositoryId = 10,
//         Type = "Note",
//         Content = "Awesome data visualization library for presentations.",
//         CreatedAt = DateTime.UtcNow
//     },
//     new Annotation
//     {
//         AnnotationId = 10,
//         UserId = "6",
//         RepositoryId = 3,
//         Type = "Note",
//         Content = "Could use this for testing in our current project.",
//         CreatedAt = DateTime.UtcNow
//     },
//     new Annotation
//     {
//         AnnotationId = 11,
//         UserId = "4",
//         RepositoryId = 7,
//         Type = "Note",
//         Content = "Sandbox looks promising for prototyping new ML models.",
//         CreatedAt = DateTime.UtcNow
//     },
//     new Annotation
//     {
//         AnnotationId = 12,
//         UserId = "3",
//         RepositoryId = 8,
//         Type = "Tag",
//         Content = "Starter Kit",
//         CreatedAt = DateTime.UtcNow
//     }
);






//    // Composite Key for UserRepository
    modelBuilder.Entity<UserRepository>()
        .HasKey(ur => new { ur.UserId, ur.RepositoryId });

    // Configure relationships
    modelBuilder.Entity<UserRepository>()
        .HasOne(ur => ur.User)
        .WithMany(u => u.UserRepositories)
        .HasForeignKey(ur => ur.UserId);

    modelBuilder.Entity<UserRepository>()
        .HasOne(ur => ur.Repository)
        .WithMany(r => r.UserRepositories)
        .HasForeignKey(ur => ur.RepositoryId);

        modelBuilder.Entity<Annotation>()
    .HasOne(a => a.User)
    .WithMany(u => u.Annotations)
    .HasForeignKey(a => a.UserId)
    .OnDelete(DeleteBehavior.Cascade);

modelBuilder.Entity<Annotation>()
    .HasOne(a => a.Repository)
    .WithMany(r => r.Annotations)
    .HasForeignKey(a => a.RepositoryId)
    .OnDelete(DeleteBehavior.Cascade);


    //  // Temporarily disable validation
    // modelBuilder.Entity<User>().Ignore(user => user.ConcurrencyStamp);
    // modelBuilder.Entity<User>().Ignore(user => user.SecurityStamp);




}
    }

}