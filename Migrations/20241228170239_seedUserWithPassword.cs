using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NSSFinalProject12_27.Migrations
{
    /// <inheritdoc />
    public partial class seedUserWithPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "6fccd4e0-b16c-47ef-9f5d-fa2ac9360d11", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN_DOE", "AQAAAAIAAYagAAAAEP6WKm31q1vcypcinDtOw1bxwxyYCDxUKNh9x93/rvV4ZJ62C6/pnKDYHj3SlBB1qQ==", null, false, "4f1231b4-f484-4926-bc4e-75109ee4c1fe", false, "john_doe" },
                    { "10", 0, "d67dc7de-d52e-4a35-a64d-209e56378c22", "daniel.evans@example.com", true, "Daniel", "Evans", false, null, "DANIEL.EVANS@EXAMPLE.COM", "DANIEL_EVANS", "AQAAAAIAAYagAAAAELerLDeSyLoJjBrLXGM+txYWj2Z85GD9yhMFdVzdWSWqRlFujTORUNk0KRKRpfbBVQ==", null, false, "97397c0b-0ad8-4925-9834-880f2dc27945", false, "daniel_evans" },
                    { "2", 0, "7029ecc7-7b45-4a57-96c9-e1dbc3fd141a", "jane.smith@example.com", true, "Jane", "Smith", false, null, "JANE.SMITH@EXAMPLE.COM", "JANE_SMITH", "AQAAAAIAAYagAAAAEH4qjuBTiRimt/W7EQiP8h/b67/z713JuVpR9ijzT+TywvqjKK0aYu3Cv82IeoVk/Q==", null, false, "4cd17035-37a3-488d-b86f-839d8dc84078", false, "jane_smith" },
                    { "3", 0, "b60b1c20-e936-4d38-a15e-b694ced508c7", "alice.brown@example.com", true, "Alice", "Brown", false, null, "ALICE.BROWN@EXAMPLE.COM", "ALICE_BROWN", "AQAAAAIAAYagAAAAEPbovJSmLnz4+jnNQqqiVRwKoysYVg4r8Q1sKb9CgUzvjeNHbnuYGJL3EbXrdKV9SA==", null, false, "cc8ef93c-7aa6-4738-b6e0-0df0aa34598f", false, "alice_brown" },
                    { "4", 0, "77a059fc-17d2-4522-98dc-ef6612f59459", "bob.jones@example.com", true, "Bob", "Jones", false, null, "BOB.JONES@EXAMPLE.COM", "BOB_JONES", "AQAAAAIAAYagAAAAENoGvUrq9IHvDLWti+1guhbG6lVdLp9MhsFRjAPe+8MEfy3f7AaDa2qCOgoXIl4VNg==", null, false, "35ac99c0-f07d-434b-bebe-4b22e5b2eb2e", false, "bob_jones" },
                    { "5", 0, "aaedb63c-8650-4208-a65c-9e22f1b68e07", "carla.white@example.com", true, "Carla", "White", false, null, "CARLA.WHITE@EXAMPLE.COM", "CARLA_WHITE", "AQAAAAIAAYagAAAAENf8Vov8vtJjAMevZ9mnEjB6S/GcOTVYefZLNJPqHsjPsXqlUKPEKDTsmR871xdWSw==", null, false, "8f02f4ca-ea8a-4f3a-b712-d42688f4ffde", false, "carla_white" },
                    { "6", 0, "6fd03d16-3b47-40d6-bb62-e684ad727727", "michael.green@example.com", true, "Michael", "Green", false, null, "MICHAEL.GREEN@EXAMPLE.COM", "MICHAEL_GREEN", "AQAAAAIAAYagAAAAEKoAGSdmljArtKDBW1PyPaVAyBX3zD+FBp8WxTiIJN89+EKACj2Xu+/rAhLlJtLXhA==", null, false, "d20c38b0-a4dc-4a19-a910-a945f176c03a", false, "michael_green" },
                    { "7", 0, "00f2784a-0fbe-4399-9fd4-09d5c8889ba5", "linda.lee@example.com", true, "Linda", "Lee", false, null, "LINDA.LEE@EXAMPLE.COM", "LINDA_LEE", "AQAAAAIAAYagAAAAEMu1lSJGCICbKKm2VvWIVfopdG0HDCtGR+H4vztDnTfuasVatjZOBeI7kzsgw7Hi+g==", null, false, "691cc4d4-3d52-46d9-b752-da6e67ea8290", false, "linda_lee" },
                    { "8", 0, "4fd39713-24b4-4085-9a64-932a405c410f", "james.brown@example.com", true, "James", "Brown", false, null, "JAMES.BROWN@EXAMPLE.COM", "JAMES_BROWN", "AQAAAAIAAYagAAAAEAjHpba81oCWdDkBCVekaTJi2v0uc703YoF0mtr5zVqaOG6dCaGnmQAwYvGs0p0SKw==", null, false, "d4987be9-98cf-44b8-9600-312f7d2603a5", false, "james_brown" },
                    { "9", 0, "8f874962-8272-493b-9dd1-1d9bda40c4af", "emma.clark@example.com", true, "Emma", "Clark", false, null, "EMMA.CLARK@EXAMPLE.COM", "EMMA_CLARK", "AQAAAAIAAYagAAAAEJf53f7IBHoCFEbBfJtZefReBk6hogqcO72vBIcrFhZzya2+dmrnnbWyhRp73L/QBQ==", null, false, "fd26350f-0565-43a1-bb0e-8fcb50f81fae", false, "emma_clark" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");
        }
    }
}
