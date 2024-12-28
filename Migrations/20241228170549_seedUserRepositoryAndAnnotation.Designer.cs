﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NSSFinalProject12_27.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NSSFinalProject12_27.Migrations
{
    [DbContext(typeof(NSSFinalProjectDbContext))]
    [Migration("20241228170549_seedUserRepositoryAndAnnotation")]
    partial class seedUserRepositoryAndAnnotation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NSSFinalProject.Models.Annotation", b =>
                {
                    b.Property<int>("AnnotationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AnnotationId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("RepositoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AnnotationId");

                    b.HasIndex("RepositoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Annotations");

                    b.HasData(
                        new
                        {
                            AnnotationId = 1,
                            Content = "This backend framework looks promising for my next project.",
                            CreatedAt = new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900),
                            RepositoryId = 1,
                            Type = "Note",
                            UserId = "1"
                        },
                        new
                        {
                            AnnotationId = 2,
                            Content = "Great library for frontend animations.",
                            CreatedAt = new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900),
                            RepositoryId = 2,
                            Type = "Note",
                            UserId = "2"
                        },
                        new
                        {
                            AnnotationId = 3,
                            Content = "AI",
                            CreatedAt = new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900),
                            RepositoryId = 3,
                            Type = "Tag",
                            UserId = "3"
                        },
                        new
                        {
                            AnnotationId = 4,
                            Content = "Data science repo with useful algorithms.",
                            CreatedAt = new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900),
                            RepositoryId = 4,
                            Type = "Note",
                            UserId = "4"
                        });
                });

            modelBuilder.Entity("NSSFinalProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Backend"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Frontend"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Artificial Intelligence"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Full Stack"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "Data Science"
                        },
                        new
                        {
                            CategoryId = 6,
                            Description = "Security"
                        },
                        new
                        {
                            CategoryId = 7,
                            Description = "Testing"
                        },
                        new
                        {
                            CategoryId = 8,
                            Description = "Machine Learning"
                        },
                        new
                        {
                            CategoryId = 9,
                            Description = "Other"
                        });
                });

            modelBuilder.Entity("NSSFinalProject.Models.Repository", b =>
                {
                    b.Property<int>("RepositoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RepositoryId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RepositoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RepositoryUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Stars")
                        .HasColumnType("integer");

                    b.HasKey("RepositoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Repositories");

                    b.HasData(
                        new
                        {
                            RepositoryId = 1,
                            CategoryId = 1,
                            Description = "A powerful backend framework for building scalable applications.",
                            Language = "C#",
                            RepositoryName = "Backend Framework",
                            RepositoryUrl = "https://github.com/example/backend-framework",
                            Stars = 1200
                        },
                        new
                        {
                            RepositoryId = 2,
                            CategoryId = 2,
                            Description = "A sleek and efficient frontend library.",
                            Language = "JavaScript",
                            RepositoryName = "Frontend Library",
                            RepositoryUrl = "https://github.com/example/frontend-library",
                            Stars = 950
                        },
                        new
                        {
                            RepositoryId = 3,
                            CategoryId = 3,
                            Description = "A comprehensive toolkit for AI research.",
                            Language = "Python",
                            RepositoryName = "AI Toolkit",
                            RepositoryUrl = "https://github.com/example/ai-toolkit",
                            Stars = 2500
                        },
                        new
                        {
                            RepositoryId = 4,
                            CategoryId = 5,
                            Description = "A hub of resources for data scientists.",
                            Language = "R",
                            RepositoryName = "Data Science Hub",
                            RepositoryUrl = "https://github.com/example/data-science-hub",
                            Stars = 1800
                        },
                        new
                        {
                            RepositoryId = 5,
                            CategoryId = 7,
                            Description = "An intuitive testing framework.",
                            Language = "Java",
                            RepositoryName = "Testing Framework",
                            RepositoryUrl = "https://github.com/example/testing-framework",
                            Stars = 700
                        });
                });

            modelBuilder.Entity("NSSFinalProject.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2b05769e-ff68-4c90-91af-0b4491d94ba6",
                            Email = "john.doe@example.com",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                            NormalizedUserName = "JOHN_DOE",
                            PasswordHash = "AQAAAAIAAYagAAAAEKrj1yfRqvUstaluX5i3xk95YhkT8YMSDLMQ7bIUO0j29EXp0/oxj1j0IXGL0G+uYQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d5bf3f92-91eb-4a10-b0f9-3148446e2bfb",
                            TwoFactorEnabled = false,
                            UserName = "john_doe"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "27adca09-6547-45e4-bfa7-ea3552bce54c",
                            Email = "jane.smith@example.com",
                            EmailConfirmed = true,
                            FirstName = "Jane",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "JANE.SMITH@EXAMPLE.COM",
                            NormalizedUserName = "JANE_SMITH",
                            PasswordHash = "AQAAAAIAAYagAAAAEHLWd8+7ICZzhK8e+4yCYldSXKElj4pHehD2MfraBPtnYKCosZxRT8sW58tBak5ATA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1b102386-557f-472e-a980-15ca142eba08",
                            TwoFactorEnabled = false,
                            UserName = "jane_smith"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b628ed1b-fb53-4a4f-8cc7-52bbb4199090",
                            Email = "alice.brown@example.com",
                            EmailConfirmed = true,
                            FirstName = "Alice",
                            LastName = "Brown",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALICE.BROWN@EXAMPLE.COM",
                            NormalizedUserName = "ALICE_BROWN",
                            PasswordHash = "AQAAAAIAAYagAAAAEPkQmjfkwiMRNOTN2qr0fq6s3c4WW5QX6rzlkjZHhF4PlUYcsV2sq/94+WR2f42IGA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b3d00652-6ba6-4a4c-92e8-96c4ca4513c3",
                            TwoFactorEnabled = false,
                            UserName = "alice_brown"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ea5e8395-ba39-41c4-8820-dbe0723d19fe",
                            Email = "bob.jones@example.com",
                            EmailConfirmed = true,
                            FirstName = "Bob",
                            LastName = "Jones",
                            LockoutEnabled = false,
                            NormalizedEmail = "BOB.JONES@EXAMPLE.COM",
                            NormalizedUserName = "BOB_JONES",
                            PasswordHash = "AQAAAAIAAYagAAAAEARG/LLTt3hQLEvWXKGXniO7WJUGz9IT0+gyXFxmD8kfox7VmhpL4wC+qSKD46VPuA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c777d997-e91c-4359-81fa-fce15781ce74",
                            TwoFactorEnabled = false,
                            UserName = "bob_jones"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2f13816b-553d-4a4b-a243-c5f3c85b7fa4",
                            Email = "carla.white@example.com",
                            EmailConfirmed = true,
                            FirstName = "Carla",
                            LastName = "White",
                            LockoutEnabled = false,
                            NormalizedEmail = "CARLA.WHITE@EXAMPLE.COM",
                            NormalizedUserName = "CARLA_WHITE",
                            PasswordHash = "AQAAAAIAAYagAAAAEAylTtHIAkiQw6fmYVZggt3PbIMDe5mMTuNwENYHUmHx0mZ4h9REpV58CbrvhQX8lA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1f5ae468-820d-4e78-a2df-ef3db21cb1e7",
                            TwoFactorEnabled = false,
                            UserName = "carla_white"
                        },
                        new
                        {
                            Id = "6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3f3b292a-229a-43d5-a25d-fa86e0d6d553",
                            Email = "michael.green@example.com",
                            EmailConfirmed = true,
                            FirstName = "Michael",
                            LastName = "Green",
                            LockoutEnabled = false,
                            NormalizedEmail = "MICHAEL.GREEN@EXAMPLE.COM",
                            NormalizedUserName = "MICHAEL_GREEN",
                            PasswordHash = "AQAAAAIAAYagAAAAEHH6b9bE7fxe1e5TVmnWQOZ+OxWQETyGsPFRfCCoZxrKpN89MHg7nYNPLixTcGxCOA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fae734cd-d8cd-4230-bc87-a1e2052e22b5",
                            TwoFactorEnabled = false,
                            UserName = "michael_green"
                        },
                        new
                        {
                            Id = "7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4d1d10e0-9cf7-4fe1-8b3b-bc4a3f69abac",
                            Email = "linda.lee@example.com",
                            EmailConfirmed = true,
                            FirstName = "Linda",
                            LastName = "Lee",
                            LockoutEnabled = false,
                            NormalizedEmail = "LINDA.LEE@EXAMPLE.COM",
                            NormalizedUserName = "LINDA_LEE",
                            PasswordHash = "AQAAAAIAAYagAAAAEBGYSPfMmDPnx7L2fJaaG2EyARJc5cSH3KJ+9aZR8lIaA0+44OTescuZZyN/c7Au/Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f57eb648-6a26-4f84-b16f-ac3edd1d60ab",
                            TwoFactorEnabled = false,
                            UserName = "linda_lee"
                        },
                        new
                        {
                            Id = "8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0c7785e1-6e10-4c6f-95b3-0ca5383cfeef",
                            Email = "james.brown@example.com",
                            EmailConfirmed = true,
                            FirstName = "James",
                            LastName = "Brown",
                            LockoutEnabled = false,
                            NormalizedEmail = "JAMES.BROWN@EXAMPLE.COM",
                            NormalizedUserName = "JAMES_BROWN",
                            PasswordHash = "AQAAAAIAAYagAAAAEMv9+VrTEau/h43Ng34LWZVoIdUnrHIyaJ7zrb1NI1zgxthKb8cXjjOowEGdJN/D2w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "73333531-eb3a-481e-90c9-5531a48a548b",
                            TwoFactorEnabled = false,
                            UserName = "james_brown"
                        },
                        new
                        {
                            Id = "9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fc1705f1-1b5b-4591-ab36-716b6c7eadf2",
                            Email = "emma.clark@example.com",
                            EmailConfirmed = true,
                            FirstName = "Emma",
                            LastName = "Clark",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMMA.CLARK@EXAMPLE.COM",
                            NormalizedUserName = "EMMA_CLARK",
                            PasswordHash = "AQAAAAIAAYagAAAAEP5yrnNDNQFB+VkCkJ4ke1qvExGJrGzaGwbpoRCuwYUljf9P2BsNkFjUqTyrBzZpeQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f91592b0-ae3b-4462-9b88-0104178f8db5",
                            TwoFactorEnabled = false,
                            UserName = "emma_clark"
                        },
                        new
                        {
                            Id = "10",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "576775a9-275b-4a36-b31a-930f74613bec",
                            Email = "daniel.evans@example.com",
                            EmailConfirmed = true,
                            FirstName = "Daniel",
                            LastName = "Evans",
                            LockoutEnabled = false,
                            NormalizedEmail = "DANIEL.EVANS@EXAMPLE.COM",
                            NormalizedUserName = "DANIEL_EVANS",
                            PasswordHash = "AQAAAAIAAYagAAAAEGD7jjopS2HEbQdo+zyh8d9+lkigy5uKCoHEqHNU14GHiiFu1GOTIAMFJb28zmEtzQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "db3784c2-0389-4c52-bc57-cdde7cac3c2d",
                            TwoFactorEnabled = false,
                            UserName = "daniel_evans"
                        });
                });

            modelBuilder.Entity("NSSFinalProject.Models.UserRepository", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<int>("RepositoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SavedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserId", "RepositoryId");

                    b.HasIndex("RepositoryId");

                    b.ToTable("UserRepositories");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RepositoryId = 1,
                            SavedAt = new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860)
                        },
                        new
                        {
                            UserId = "2",
                            RepositoryId = 2,
                            SavedAt = new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860)
                        },
                        new
                        {
                            UserId = "3",
                            RepositoryId = 3,
                            SavedAt = new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860)
                        },
                        new
                        {
                            UserId = "4",
                            RepositoryId = 4,
                            SavedAt = new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860)
                        },
                        new
                        {
                            UserId = "5",
                            RepositoryId = 5,
                            SavedAt = new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NSSFinalProject.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NSSFinalProject.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NSSFinalProject.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NSSFinalProject.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NSSFinalProject.Models.Annotation", b =>
                {
                    b.HasOne("NSSFinalProject.Models.Repository", "Repository")
                        .WithMany("Annotations")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NSSFinalProject.Models.User", "User")
                        .WithMany("Annotations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Repository");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NSSFinalProject.Models.Repository", b =>
                {
                    b.HasOne("NSSFinalProject.Models.Category", "Category")
                        .WithMany("Repositories")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NSSFinalProject.Models.UserRepository", b =>
                {
                    b.HasOne("NSSFinalProject.Models.Repository", "Repository")
                        .WithMany("UserRepositories")
                        .HasForeignKey("RepositoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NSSFinalProject.Models.User", "User")
                        .WithMany("UserRepositories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Repository");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NSSFinalProject.Models.Category", b =>
                {
                    b.Navigation("Repositories");
                });

            modelBuilder.Entity("NSSFinalProject.Models.Repository", b =>
                {
                    b.Navigation("Annotations");

                    b.Navigation("UserRepositories");
                });

            modelBuilder.Entity("NSSFinalProject.Models.User", b =>
                {
                    b.Navigation("Annotations");

                    b.Navigation("UserRepositories");
                });
#pragma warning restore 612, 618
        }
    }
}