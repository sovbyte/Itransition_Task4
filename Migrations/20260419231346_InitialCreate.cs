using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Itransition_Task4.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ConfirmationToken", "Email", "HashedPassword", "LastLoginTime", "Name", "RegistrationDate", "ResetToken", "Status" },
                values: new object[,]
                {
                    { 1, null, "admin@example.com", "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", new DateTime(2026, 4, 19, 22, 49, 13, 145, DateTimeKind.Utc).AddTicks(9431), "Admin", new DateTime(2026, 4, 19, 22, 49, 12, 848, DateTimeKind.Utc).AddTicks(1131), null, 1 },
                    { 2, null, "john@example.com", "$2a$11$bJ0xzWrOxlOglTbVIvKFd.eCJH5VrLvAwfsZ2UIe.byEs021hgWQ.", new DateTime(2026, 4, 18, 22, 49, 13, 295, DateTimeKind.Utc).AddTicks(2236), "John Doe", new DateTime(2026, 4, 19, 22, 49, 13, 146, DateTimeKind.Utc).AddTicks(1433), null, 1 },
                    { 3, null, "jane@example.com", "$2a$11$eYctyqiQnVhP6S3aVXb0xOGaaha/4sYTwiZ2HYHVLoHy5wkXjcF66", new DateTime(2026, 4, 19, 17, 49, 13, 443, DateTimeKind.Utc).AddTicks(6606), "Jane Smith", new DateTime(2026, 4, 19, 22, 49, 13, 295, DateTimeKind.Utc).AddTicks(2479), null, 1 },
                    { 4, null, "ivan@example.com", "$2a$11$lPsm3NIplxn6pgiqOPSxuuiURX6dYfVYhVB2uSsVp5XwA7J.NHI/q", new DateTime(2026, 4, 16, 22, 49, 13, 593, DateTimeKind.Utc).AddTicks(7017), "Ivan Ivanov", new DateTime(2026, 4, 19, 22, 49, 13, 443, DateTimeKind.Utc).AddTicks(6849), null, 1 }
                });
        }
    }
}
