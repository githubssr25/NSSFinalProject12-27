using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NSSFinalProject12_27.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5fc721e-6d98-4679-b011-d05c6364b5ae", "AQAAAAIAAYagAAAAEOq55BAWd29L6udyEeg/20jkOKxgH4AmbixfO214Ec1edRPG//c9wpwrO7FJy3li7Q==", "c8244756-899f-4be7-a64b-4f771a0757cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76a296eb-7b46-49d7-a383-92d792a8f7a3", "AQAAAAIAAYagAAAAEOkRN/ZoFG6qmtkO+KHeWKBLzuT8nfoxORuvK/l43RkODY/0p3h4jO/j0zpzWczjOg==", "088b4514-aa48-4f87-92c3-8a0758e5599f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce8736fa-5959-425c-938a-81811fb26a8f", "AQAAAAIAAYagAAAAECke8KDqf7w1XiFypLtdD/wQ7/xSAtV+0kPmvhbCdT07hcv/BPW+iiZZ7dZ09k3kyQ==", "7e5ede00-393b-4bb1-ae41-d8b03f262b73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b311fa28-8f22-495c-a702-be49005fc4c0", "AQAAAAIAAYagAAAAENXHE7t3Wy+ycGyYN7seKv9Thn69Cbbv0MxyWezc58A9okQ9EP/MHwruwG2GesZ9Tg==", "d6bcf5bf-7599-4412-a414-3c51289db3a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14120af4-8300-4b8f-aad1-5f49c1edeee0", "AQAAAAIAAYagAAAAEDGiApN5Qvme5DY741ko9PwPmg/FSAbVTYkOP42lphIdTTuk+tKG+j3+2rnfWDI2BQ==", "f44068e7-eece-4a8b-be34-a4d9613e1917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f759c03e-083a-42df-b141-a32a381f5ba4", "AQAAAAIAAYagAAAAEETrIBqtS9yv/bwtAjmWKD8bN9yBCFioWm7twVFy+K/FHQHeplCdxj0oK4xDGIMIKg==", "8f9a9d39-913d-46f2-9b38-6f05dc6327ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47dd0255-3539-461c-8d72-63cb1b7a26c5", "AQAAAAIAAYagAAAAEPZ5UFjvhtegJh71JUQi3x+GTowgD878Y9CxQ1lmZ5u/STjwrZkzUfijlD1EEBw6iQ==", "bd37b527-74b7-431f-a490-7b197fb24bda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83d3b62e-b985-40cf-8a26-8130c64e6ade", "AQAAAAIAAYagAAAAED7orH4j9TNVPh74MSLYXEGZ4Avj3l0V3kO/AVkeK0I1VI0FR72cULPFg22jdndmxA==", "c86630ab-6d83-4aea-ae36-3c4b2e934ba2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2007e017-6a8d-4a27-9c10-6d066f7b27c9", "AQAAAAIAAYagAAAAEPANjshPm1BsAfQpSKGKCEIqxzkyfR6E9TdGPNc9R2QNanyuair61/6d6cHZkQkJbQ==", "79bc71f4-0874-4191-a466-8775f60d0e56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "487e2dbc-008e-4be9-8611-349536650554", "AQAAAAIAAYagAAAAEHq3KSeYC08Lzq3ZLOh8ipTraMajlRQ+rNsn/jV0UUZ6Q+CKheoN5ovWqz10eq0zjA==", "246ae30b-6040-4372-bf4d-93e6d470b851" });

            migrationBuilder.InsertData(
                table: "Repositories",
                columns: new[] { "RepositoryId", "CategoryId", "Description", "Language", "RepositoryName", "RepositoryUrl", "Stars" },
                values: new object[,]
                {
                    { 8, 6, "A comprehensive toolkit for cyber security.", "Python", "Cyber Security Toolkit", "https://github.com/example/security-toolkit", 1300 },
                    { 9, 7, "A robust framework for automated testing.", "Java", "Testing Framework Pro", "https://github.com/example/testing-framework-pro", 1100 },
                    { 10, 8, "An interactive sandbox for machine learning models.", "Python", "Machine Learning Sandbox", "https://github.com/example/ml-sandbox", 2000 },
                    { 11, 4, "A starter kit for full stack development projects.", "TypeScript", "Full Stack Starter Kit", "https://github.com/example/full-stack-starter", 1500 },
                    { 12, 5, "A library for creating stunning data visualizations.", "JavaScript", "Data Visualization Library", "https://github.com/example/data-visualization-lib", 1400 }
                });

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 1, "1" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 2, "2" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 3, "3" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 4, "4" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 5, "5" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.InsertData(
                table: "Annotations",
                columns: new[] { "AnnotationId", "Content", "CreatedAt", "RepositoryId", "Type", "UserId" },
                values: new object[,]
                {
                    { 6, "Automated Testing", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960), 9, "Tag", "7" },
                    { 7, "Great sandbox for testing ML algorithms.", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960), 10, "Note", "8" },
                    { 8, "Full Stack", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960), 11, "Tag", "9" },
                    { 9, "Awesome data visualization library for presentations.", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960), 12, "Note", "10" },
                    { 10, "Could use this for testing in our current project.", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960), 9, "Note", "1" },
                    { 11, "Sandbox looks promising for prototyping new ML models.", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(9050), 10, "Note", "2" },
                    { 12, "Starter Kit", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(9050), 11, "Tag", "3" }
                });

            migrationBuilder.InsertData(
                table: "UserRepositories",
                columns: new[] { "RepositoryId", "UserId", "SavedAt" },
                values: new object[,]
                {
                    { 9, "1", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920) },
                    { 12, "10", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920) },
                    { 10, "2", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920) },
                    { 11, "3", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920) },
                    { 12, "4", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8930) },
                    { 8, "5", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8930) },
                    { 8, "6", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920) },
                    { 9, "7", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920) },
                    { 10, "8", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920) },
                    { 11, "9", new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 9, "1" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 12, "10" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 10, "2" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 11, "3" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 12, "4" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 8, "5" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 8, "6" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 9, "7" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 10, "8" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 11, "9" });

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b05769e-ff68-4c90-91af-0b4491d94ba6", "AQAAAAIAAYagAAAAEKrj1yfRqvUstaluX5i3xk95YhkT8YMSDLMQ7bIUO0j29EXp0/oxj1j0IXGL0G+uYQ==", "d5bf3f92-91eb-4a10-b0f9-3148446e2bfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "576775a9-275b-4a36-b31a-930f74613bec", "AQAAAAIAAYagAAAAEGD7jjopS2HEbQdo+zyh8d9+lkigy5uKCoHEqHNU14GHiiFu1GOTIAMFJb28zmEtzQ==", "db3784c2-0389-4c52-bc57-cdde7cac3c2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27adca09-6547-45e4-bfa7-ea3552bce54c", "AQAAAAIAAYagAAAAEHLWd8+7ICZzhK8e+4yCYldSXKElj4pHehD2MfraBPtnYKCosZxRT8sW58tBak5ATA==", "1b102386-557f-472e-a980-15ca142eba08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b628ed1b-fb53-4a4f-8cc7-52bbb4199090", "AQAAAAIAAYagAAAAEPkQmjfkwiMRNOTN2qr0fq6s3c4WW5QX6rzlkjZHhF4PlUYcsV2sq/94+WR2f42IGA==", "b3d00652-6ba6-4a4c-92e8-96c4ca4513c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea5e8395-ba39-41c4-8820-dbe0723d19fe", "AQAAAAIAAYagAAAAEARG/LLTt3hQLEvWXKGXniO7WJUGz9IT0+gyXFxmD8kfox7VmhpL4wC+qSKD46VPuA==", "c777d997-e91c-4359-81fa-fce15781ce74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f13816b-553d-4a4b-a243-c5f3c85b7fa4", "AQAAAAIAAYagAAAAEAylTtHIAkiQw6fmYVZggt3PbIMDe5mMTuNwENYHUmHx0mZ4h9REpV58CbrvhQX8lA==", "1f5ae468-820d-4e78-a2df-ef3db21cb1e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f3b292a-229a-43d5-a25d-fa86e0d6d553", "AQAAAAIAAYagAAAAEHH6b9bE7fxe1e5TVmnWQOZ+OxWQETyGsPFRfCCoZxrKpN89MHg7nYNPLixTcGxCOA==", "fae734cd-d8cd-4230-bc87-a1e2052e22b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d1d10e0-9cf7-4fe1-8b3b-bc4a3f69abac", "AQAAAAIAAYagAAAAEBGYSPfMmDPnx7L2fJaaG2EyARJc5cSH3KJ+9aZR8lIaA0+44OTescuZZyN/c7Au/Q==", "f57eb648-6a26-4f84-b16f-ac3edd1d60ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c7785e1-6e10-4c6f-95b3-0ca5383cfeef", "AQAAAAIAAYagAAAAEMv9+VrTEau/h43Ng34LWZVoIdUnrHIyaJ7zrb1NI1zgxthKb8cXjjOowEGdJN/D2w==", "73333531-eb3a-481e-90c9-5531a48a548b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc1705f1-1b5b-4591-ab36-716b6c7eadf2", "AQAAAAIAAYagAAAAEP5yrnNDNQFB+VkCkJ4ke1qvExGJrGzaGwbpoRCuwYUljf9P2BsNkFjUqTyrBzZpeQ==", "f91592b0-ae3b-4462-9b88-0104178f8db5" });

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 1, "1" },
                column: "SavedAt",
                value: new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 2, "2" },
                column: "SavedAt",
                value: new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 3, "3" },
                column: "SavedAt",
                value: new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 4, "4" },
                column: "SavedAt",
                value: new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 5, "5" },
                column: "SavedAt",
                value: new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860));
        }
    }
}
