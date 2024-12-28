using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NSSFinalProject12_27.Migrations
{
    /// <inheritdoc />
    public partial class seedRepository : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Repositories",
                columns: new[] { "RepositoryId", "CategoryId", "Description", "Language", "RepositoryName", "RepositoryUrl", "Stars" },
                values: new object[,]
                {
                    { 1, 1, "A powerful backend framework for building scalable applications.", "C#", "Backend Framework", "https://github.com/example/backend-framework", 1200 },
                    { 2, 2, "A sleek and efficient frontend library.", "JavaScript", "Frontend Library", "https://github.com/example/frontend-library", 950 },
                    { 3, 3, "A comprehensive toolkit for AI research.", "Python", "AI Toolkit", "https://github.com/example/ai-toolkit", 2500 },
                    { 4, 5, "A hub of resources for data scientists.", "R", "Data Science Hub", "https://github.com/example/data-science-hub", 1800 },
                    { 5, 7, "An intuitive testing framework.", "Java", "Testing Framework", "https://github.com/example/testing-framework", 700 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Repositories",
                keyColumn: "RepositoryId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fccd4e0-b16c-47ef-9f5d-fa2ac9360d11", "AQAAAAIAAYagAAAAEP6WKm31q1vcypcinDtOw1bxwxyYCDxUKNh9x93/rvV4ZJ62C6/pnKDYHj3SlBB1qQ==", "4f1231b4-f484-4926-bc4e-75109ee4c1fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d67dc7de-d52e-4a35-a64d-209e56378c22", "AQAAAAIAAYagAAAAELerLDeSyLoJjBrLXGM+txYWj2Z85GD9yhMFdVzdWSWqRlFujTORUNk0KRKRpfbBVQ==", "97397c0b-0ad8-4925-9834-880f2dc27945" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7029ecc7-7b45-4a57-96c9-e1dbc3fd141a", "AQAAAAIAAYagAAAAEH4qjuBTiRimt/W7EQiP8h/b67/z713JuVpR9ijzT+TywvqjKK0aYu3Cv82IeoVk/Q==", "4cd17035-37a3-488d-b86f-839d8dc84078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b60b1c20-e936-4d38-a15e-b694ced508c7", "AQAAAAIAAYagAAAAEPbovJSmLnz4+jnNQqqiVRwKoysYVg4r8Q1sKb9CgUzvjeNHbnuYGJL3EbXrdKV9SA==", "cc8ef93c-7aa6-4738-b6e0-0df0aa34598f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77a059fc-17d2-4522-98dc-ef6612f59459", "AQAAAAIAAYagAAAAENoGvUrq9IHvDLWti+1guhbG6lVdLp9MhsFRjAPe+8MEfy3f7AaDa2qCOgoXIl4VNg==", "35ac99c0-f07d-434b-bebe-4b22e5b2eb2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaedb63c-8650-4208-a65c-9e22f1b68e07", "AQAAAAIAAYagAAAAENf8Vov8vtJjAMevZ9mnEjB6S/GcOTVYefZLNJPqHsjPsXqlUKPEKDTsmR871xdWSw==", "8f02f4ca-ea8a-4f3a-b712-d42688f4ffde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd03d16-3b47-40d6-bb62-e684ad727727", "AQAAAAIAAYagAAAAEKoAGSdmljArtKDBW1PyPaVAyBX3zD+FBp8WxTiIJN89+EKACj2Xu+/rAhLlJtLXhA==", "d20c38b0-a4dc-4a19-a910-a945f176c03a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00f2784a-0fbe-4399-9fd4-09d5c8889ba5", "AQAAAAIAAYagAAAAEMu1lSJGCICbKKm2VvWIVfopdG0HDCtGR+H4vztDnTfuasVatjZOBeI7kzsgw7Hi+g==", "691cc4d4-3d52-46d9-b752-da6e67ea8290" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fd39713-24b4-4085-9a64-932a405c410f", "AQAAAAIAAYagAAAAEAjHpba81oCWdDkBCVekaTJi2v0uc703YoF0mtr5zVqaOG6dCaGnmQAwYvGs0p0SKw==", "d4987be9-98cf-44b8-9600-312f7d2603a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f874962-8272-493b-9dd1-1d9bda40c4af", "AQAAAAIAAYagAAAAEJf53f7IBHoCFEbBfJtZefReBk6hogqcO72vBIcrFhZzya2+dmrnnbWyhRp73L/QBQ==", "fd26350f-0565-43a1-bb0e-8fcb50f81fae" });
        }
    }
}
