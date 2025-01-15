using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NSSFinalProject12_27.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatorUserIdToRepository : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorUserId",
                table: "Repositories",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021dcc24-74c5-43e8-930a-4d52faf4e895", "AQAAAAIAAYagAAAAENvc9w9jhVPLnTAWLw3l73o2JC8/OQgRDD/kgxyTVHwcvo5Aj1azn6OtoI2+pIcc/w==", "5367b0db-b2f7-4ef4-aa8f-bd5f2e295511" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "308299cb-d3a3-4fb4-9df5-2e7c28f46578", "AQAAAAIAAYagAAAAEFIz/PyyV3FufEPZIoFC8ZjiyE4jkxTBbJ72CECyJ327CNhFzKwe2XaYTAVVl/voAg==", "7a60b13b-70dc-4e2b-97d0-c246f72d55e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45dfc125-583c-4ff8-85ec-931f7c55db44", "AQAAAAIAAYagAAAAEBLDgbqoB2+6ZW4DfEqLPJzXRFmUFFFoWPokkaGqZzNzxGwFk3MpfcTh9M9D0xc2FQ==", "cea86e96-0210-4a93-abea-8ed0de05cc41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fabd3d51-cf76-4927-856b-c3d9da55fe31", "AQAAAAIAAYagAAAAEFp+7WzY2TkvzfN3mNLixwRT5mzfcm48NYyoiESmagPBav2PgLnmmPJ5r1yPr9kUuQ==", "2a24a3ae-e2c1-4e5d-99c0-6521ad16754a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c13d0ff-531d-455d-adb2-19ef56adfcf6", "AQAAAAIAAYagAAAAECaghE+8EWAbz0fV3EYonJmtV6GVEO/XFUJRgh42dQc3Rcr2URn0aJKR4oAuK5jKgA==", "be735619-5d9f-4d3b-8a41-c16118fa5fef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70b7e97b-6e5f-4a37-bea2-43c4f2fb91d3", "AQAAAAIAAYagAAAAEMtK1OFV4MHDsbBTaDP7U0i/AznjLUt9e/Pfbo2FPcS3E984tY20I9dtK8ilOBwfvA==", "8fe1ecba-8692-4357-8454-6edf4a2de57c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7357ee3a-5413-4745-a46f-3d781f870f86", "AQAAAAIAAYagAAAAEOVvZXtyYmEc+wqjO0Pu2D1ODZKDMOCQY6uiwM7yJVQX0GgNKTEX9NtmNURHmwijQg==", "2a366513-f120-4e03-90cf-a6c27c5060a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "149528a1-6726-436e-a3ff-6e286f906d26", "AQAAAAIAAYagAAAAEDDI1DgXe0x3ZAnDzkA7Vh56SpR/aakX4OGSiWq92ZnGhlcIWVUoJVuil8+GCcQKAQ==", "8ab9a858-6b76-4e90-85f0-2c322cf8c129" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb7bec00-54b0-4043-a879-3323afb80b4d", "AQAAAAIAAYagAAAAEMXNodJwLiJ1wPnqRnK8jSDXJw63veOO90jiRu8d9SmM98HxNb1Ck0nwcWr6Nm7tsA==", "6bb140a0-9d8f-49b2-8eda-50903917f035" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8d88979-57f5-48b3-b701-6c5e700fb45f", "AQAAAAIAAYagAAAAEKdRNdvCR5hAW/QTld/O9qu8lVdRkyy9idWfRJHtvpCB+bvqQ0uY7ZoFW5vKY4+uvQ==", "b1ec4b46-64d5-4c19-8def-f3d266ce7703" });

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 1,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 2,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 3,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 4,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 5,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 8,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 9,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 10,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 11,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 12,
                column: "CreatorUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 1, "1" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 9, "1" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 12, "10" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 2, "2" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 10, "2" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 3, "3" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 11, "3" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 4, "4" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 12, "4" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 5, "5" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 8, "5" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 8, "6" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 9, "7" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 10, "8" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 11, "9" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 15, 21, 19, 6, 325, DateTimeKind.Utc).AddTicks(5090));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Repositories");

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
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(9050));

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

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 1, "1" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 9, "1" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 12, "10" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 2, "2" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 10, "2" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 3, "3" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 11, "3" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 4, "4" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 12, "4" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 5, "5" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 8, "5" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 8, "6" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 9, "7" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 10, "8" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 11, "9" },
                column: "SavedAt",
                value: new DateTime(2025, 1, 2, 19, 3, 20, 808, DateTimeKind.Utc).AddTicks(8920));
        }
    }
}
