using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NSSFinalProject12_27.Migrations
{
    /// <inheritdoc />
    public partial class seedUserRepositoryAndAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Annotations",
                columns: new[] { "AnnotationId", "Content", "CreatedAt", "RepositoryId", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, "This backend framework looks promising for my next project.", new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900), 1, "Note", "1" },
                    { 2, "Great library for frontend animations.", new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900), 2, "Note", "2" },
                    { 3, "AI", new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900), 3, "Tag", "3" },
                    { 4, "Data science repo with useful algorithms.", new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7900), 4, "Note", "4" }
                });

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

            migrationBuilder.InsertData(
                table: "UserRepositories",
                columns: new[] { "RepositoryId", "UserId", "SavedAt" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860) },
                    { 2, "2", new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860) },
                    { 3, "3", new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860) },
                    { 4, "4", new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860) },
                    { 5, "5", new DateTime(2024, 12, 28, 17, 5, 49, 630, DateTimeKind.Utc).AddTicks(7860) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Annotations",
                keyColumn: "AnnotationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 1, "1" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 2, "2" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 3, "3" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 4, "4" });

            migrationBuilder.DeleteData(
                table: "UserRepositories",
                keyColumns: new[] { "RepositoryId", "UserId" },
                keyValues: new object[] { 5, "5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf0d9835-1bbe-4d46-8f6b-2395404a57cf", "AQAAAAIAAYagAAAAEGqriuHW01Gcc/oprmlcedvqJKmtvBkuMhBSNag+1Xx0HpHlNr4vEANTxoNBtLA8BA==", "8293b774-3f0a-412f-9034-a13eaf1c274b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52df9449-293f-4c57-9d4d-4deaa05f8cb3", "AQAAAAIAAYagAAAAEOTQYbEiZV4dIajndsGV5r+NCCAEp0OeqWCpsssKZc4k1avizk1wXGlHFMFjMTiusA==", "71c0b05c-946f-4707-9bba-f7b95b6ddaa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d13468d8-8f05-4af2-af67-e9d6e8e4b609", "AQAAAAIAAYagAAAAEMoUWHW6y/dZBvG3Y30WuyAhPnVERdmORYltT6qv3TerDZ8bdKGqDpV8CWzD4+Z8lA==", "28ccf65d-967d-417c-874d-2069b84cd0aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61eed288-687a-4fe5-a9cf-9111e6acb351", "AQAAAAIAAYagAAAAEPyvVbBGhOb8RDAuDjKy8VECTw5YC1RZYPxVqxJVbgWR6a4cCKpWDdwpu54hlnqJeQ==", "9582a9fb-5533-4767-a26b-2a58f163ea5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3755889-f27f-4396-b47e-af9bac3a0975", "AQAAAAIAAYagAAAAEDAJ2ZzBpWI2kxfjYOdBunJTZwbFstjSZjXb/1jKxeOsa+A8n+gqc5jJmASUJxgyvQ==", "78057bb1-e301-4023-87d0-c549cf640109" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "923ec0c2-a566-4bad-969c-04bbc21df95c", "AQAAAAIAAYagAAAAEOgjhXoH+OU1ju+l+NSWo/5v9iSKGmbKbyQNSa2N9fRElZrMXEcojRHdhFtU6Nhr3g==", "c0e7d23b-e796-4d6b-9200-1a02eee32bc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36ba88da-4524-4b02-b294-0a658c0dded4", "AQAAAAIAAYagAAAAEFoDtoQpxICCYn1tuPCCwjQwsfNM5ovPQr0OuHyCcY+NIi3B2T3OOhEcftfFSXu+mw==", "94eca704-27df-4fd5-ae18-fcda6874ae5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab5e4963-093e-4cf4-b88a-8200fd86ef87", "AQAAAAIAAYagAAAAEKLD+ZeU3TRsC9vuTXyfkXBqUrSRf/X1bohvfZOIXfXwawjwysJTyOGDzRguDJL9XQ==", "4dd69c0a-6df2-403e-8c20-0ac47bb5c6e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2537d880-80b5-4b27-b81f-5540f3540885", "AQAAAAIAAYagAAAAEAuBZK9As6NJxAYgEgs8fvoOTr2zTBp0nmk6Uuk8nYUCW+NjxjISGx25fhEJ9GHzww==", "34834518-7ba4-48eb-a6ae-d28a551bef6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41781115-84d5-4da0-98ca-3ed9b781ab7e", "AQAAAAIAAYagAAAAEAdhJ2ZpubNZOO35/9LUKhhnedBZ1oQciOhuyqZDRnzrdVOvF0R3cqnGgemow/bgzA==", "80f70f4e-d6a9-44a3-9516-e2c8fd456333" });
        }
    }
}
