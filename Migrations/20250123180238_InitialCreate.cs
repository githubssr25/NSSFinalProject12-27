using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NSSFinalProject12_27.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repositories",
                columns: table => new
                {
                    RepositoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RepositoryName = table.Column<string>(type: "text", nullable: false),
                    RepositoryUrl = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Language = table.Column<string>(type: "text", nullable: false),
                    Stars = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    CreatorUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repositories", x => x.RepositoryId);
                    table.ForeignKey(
                        name: "FK_Repositories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Annotations",
                columns: table => new
                {
                    AnnotationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RepositoryId = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annotations", x => x.AnnotationId);
                    table.ForeignKey(
                        name: "FK_Annotations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Annotations_Repositories_RepositoryId",
                        column: x => x.RepositoryId,
                        principalTable: "Repositories",
                        principalColumn: "RepositoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRepositories",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RepositoryId = table.Column<int>(type: "integer", nullable: false),
                    SavedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRepositories", x => new { x.UserId, x.RepositoryId });
                    table.ForeignKey(
                        name: "FK_UserRepositories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRepositories_Repositories_RepositoryId",
                        column: x => x.RepositoryId,
                        principalTable: "Repositories",
                        principalColumn: "RepositoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "7ea1fa0a-7735-4905-b9e4-5347ff3b30a5", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", "AQAAAAIAAYagAAAAEItgi/ITIGUs2bhF64whahwE3F2sR9lqES//S5CzSaTP/sIjvag2ZMLWXAMLGE678g==", null, false, "33a9185e-e68c-4ba0-a49a-928984d12845", false, "john_doe" },
                    { "10", 0, "f199a769-314d-4e06-9060-dfe606aaadcb", "daniel.evans@example.com", true, "Daniel", "Evans", false, null, "DANIEL.EVANS@EXAMPLE.COM", "DANIEL_EVANS", "AQAAAAIAAYagAAAAEJt2Hv/Zlf2heSOOAf5/pI8w7GkVnDhiTqoukjD3cuMLFxjurE2BGGLFG00L9rpPDQ==", null, false, "018d47ee-f929-4fca-a82f-66e046077d81", false, "daniel_evans" },
                    { "2", 0, "910c55af-1d0b-4e36-bde6-a78ee3731bae", "jane.smith@example.com", true, "Jane", "Smith", false, null, "JANE.SMITH@EXAMPLE.COM", "JANE_SMITH", "AQAAAAIAAYagAAAAELfcGDHGcayGVEUYebxcQ2fyeTfqZiMPk1EE9BNb0zmk7l05ST2hmjCLlVgUxv4UhA==", null, false, "c1ffeec9-99b0-4a6c-8ef1-878229a8243f", false, "jane_smith" },
                    { "3", 0, "52073590-7624-4415-a871-cb48763dd6fc", "alice.brown@example.com", true, "Alice", "Brown", false, null, "ALICE.BROWN@EXAMPLE.COM", "ALICE_BROWN", "AQAAAAIAAYagAAAAEGVgnBS9pc4WZaKm4jcky/2SVQ+T8VwKL6XiU02w0qGe2MNTwclMQ0AakOB10pXECg==", null, false, "eca6ae94-e3f4-4157-84c2-cf59319c5a5f", false, "alice_brown" },
                    { "4", 0, "32266dd8-8c1e-4a3a-9546-d34d64cebf60", "bob.jones@example.com", true, "Bob", "Jones", false, null, "BOB.JONES@EXAMPLE.COM", "BOB_JONES", "AQAAAAIAAYagAAAAEKmuDXut8/c4yBhbVz9jlzGfRRxO0T6OhgeKyBKrjZ8AuA8i1JLbNhlBhUZSDbJ/2Q==", null, false, "8dc12854-430c-48e1-aefb-ce5eca2f24b9", false, "bob_jones" },
                    { "5", 0, "ec71c303-0e3e-4960-a35e-72030a2c16d6", "carla.white@example.com", true, "Carla", "White", false, null, "CARLA.WHITE@EXAMPLE.COM", "CARLA_WHITE", "AQAAAAIAAYagAAAAEM55Wqv8abQ2Ubr+JVS7+DvKehIfvKr4j1BEhpgSxz4v9FmWfiMnPhO5euiQdnzXkg==", null, false, "3deba606-d0d5-4dc0-a7bc-d153fa5302b7", false, "carla_white" },
                    { "6", 0, "00420993-218a-49c5-8d6f-66b35269ab52", "michael.green@example.com", true, "Michael", "Green", false, null, "MICHAEL.GREEN@EXAMPLE.COM", "MICHAEL_GREEN", "AQAAAAIAAYagAAAAELy9+zJrEo7frWeJBP+eN6uqJK4iB20tdGMFIhqvUN14ATA+WrQamS+ylFRBLWz+Ug==", null, false, "43b48886-36d6-434e-959b-12a2c2f42d86", false, "michael_green" },
                    { "7", 0, "b9c6b839-5e2c-4d7e-819e-d9dbf5590833", "linda.lee@example.com", true, "Linda", "Lee", false, null, "LINDA.LEE@EXAMPLE.COM", "LINDA_LEE", "AQAAAAIAAYagAAAAEPwHluT/Pes4reL5H57xvlfzlJ347g5dXvjKarQEGTZwjQpOPS8qoXIZM5GabEbMWQ==", null, false, "18733c7d-fb99-4260-8692-cde07b45d6f3", false, "linda_lee" },
                    { "8", 0, "3c1a9d94-434a-478b-a7cd-7a2e0cc73b8c", "james.brown@example.com", true, "James", "Brown", false, null, "JAMES.BROWN@EXAMPLE.COM", "JAMES_BROWN", "AQAAAAIAAYagAAAAEDqkt9xH7zuwlircvhUZuysU3cxLYlzy+QSsO2umENlkfPVJw16gYiv4/kA10yVydQ==", null, false, "d02cec7e-f62a-4f58-b239-65f1b4ab730c", false, "james_brown" },
                    { "9", 0, "917d0172-3448-4087-a059-9d914769297b", "emma.clark@example.com", true, "Emma", "Clark", false, null, "EMMA.CLARK@EXAMPLE.COM", "EMMA_CLARK", "AQAAAAIAAYagAAAAEM28kcAw0VmofuUDXnzx83INrnZf7NW30scOCHEB102Kekk6x0WE1aSf7CyKPXv/RA==", null, false, "a942c843-a274-47e3-a01f-b8a809a656d2", false, "emma_clark" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description" },
                values: new object[,]
                {
                    { 1, "Backend" },
                    { 2, "Frontend" },
                    { 3, "Artificial Intelligence" },
                    { 4, "Full Stack" },
                    { 5, "Data Science" },
                    { 6, "Security" },
                    { 7, "Testing" },
                    { 8, "Machine Learning" },
                    { 9, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Repositories",
                columns: new[] { "RepositoryId", "CategoryId", "CreatorUserId", "Description", "Language", "RepositoryName", "RepositoryUrl", "Stars" },
                values: new object[,]
                {
                    { 1, 1, "1", "A powerful backend framework for building scalable applications.", "C#", "Backend Framework", "https://github.com/example/backend-framework", 1200 },
                    { 2, 2, "2", "A sleek and efficient frontend library.", "JavaScript", "Frontend Library", "https://github.com/example/frontend-library", 950 },
                    { 3, 3, "3", "A comprehensive toolkit for AI research.", "Python", "AI Toolkit", "https://github.com/example/ai-toolkit", 2500 },
                    { 4, 5, "4", "A hub of resources for data scientists.", "R", "Data Science Hub", "https://github.com/example/data-science-hub", 1800 },
                    { 5, 7, "5", "An intuitive testing framework.", "Java", "Testing Framework", "https://github.com/example/testing-framework", 700 },
                    { 6, 6, "6", "A comprehensive toolkit for cyber security.", "Python", "Cyber Security Toolkit", "https://github.com/example/security-toolkit", 1300 },
                    { 7, 6, "7", "An AI-driven system to detect and prevent security threats.", "Python", "AI-Powered Threat Detection", "https://github.com/example/ai-threat-detection", 1700 },
                    { 8, 6, "8", "A suite of tools to secure cloud environments efficiently.", "Go", "Cloud Security Suite", "https://github.com/example/cloud-security-suite", 1900 },
                    { 9, 2, "9", "A powerful web scraping tool with automation features.", "JavaScript", "Web Scraper Pro", "https://github.com/example/web-scraper-pro", 1500 },
                    { 10, 8, "10", "An interactive sandbox for machine learning models.", "Python", "Machine Learning Sandbox", "https://github.com/example/ml-sandbox", 2000 },
                    { 11, 4, "2", "A starter kit for full stack development projects.", "TypeScript", "Full Stack Starter Kit", "https://github.com/example/full-stack-starter", 1500 },
                    { 12, 5, "4", "A library for creating stunning data visualizations.", "JavaScript", "Data Visualization Library", "https://github.com/example/data-visualization-lib", 1400 }
                });

            migrationBuilder.InsertData(
                table: "Annotations",
                columns: new[] { "AnnotationId", "Content", "CreatedAt", "RepositoryId", "Type", "UserId" },
                values: new object[] { 1, "This backend framework looks promising for my next project.", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2280), 1, "Note", "1" });

            migrationBuilder.InsertData(
                table: "UserRepositories",
                columns: new[] { "RepositoryId", "UserId", "SavedAt" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2190) },
                    { 5, "1", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 7, "10", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2220) },
                    { 10, "10", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2200) },
                    { 2, "2", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2200) },
                    { 6, "2", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 11, "2", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 3, "3", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2200) },
                    { 5, "3", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 8, "3", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2220) },
                    { 4, "4", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2200) },
                    { 7, "4", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 12, "4", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 5, "5", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2200) },
                    { 6, "5", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 3, "6", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 6, "6", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2200) },
                    { 8, "6", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2220) },
                    { 7, "7", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2200) },
                    { 8, "7", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2220) },
                    { 3, "8", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 8, "8", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2200) },
                    { 5, "9", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 7, "9", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2210) },
                    { 9, "9", new DateTime(2025, 1, 23, 18, 2, 38, 700, DateTimeKind.Utc).AddTicks(2200) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_RepositoryId",
                table: "Annotations",
                column: "RepositoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Annotations_UserId",
                table: "Annotations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_CategoryId",
                table: "Repositories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRepositories_RepositoryId",
                table: "UserRepositories",
                column: "RepositoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Annotations");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "UserRepositories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Repositories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
