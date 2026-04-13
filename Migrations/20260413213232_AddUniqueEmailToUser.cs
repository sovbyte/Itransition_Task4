using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Itransition_Task4.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueEmailToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    LastLoginTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Statuses = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "LastLoginTime", "Name", "Statuses" },
                values: new object[,]
                {
                    { 1, "admin@example.com", new DateTime(2026, 4, 13, 21, 32, 31, 205, DateTimeKind.Utc).AddTicks(8643), "Admin", 1 },
                    { 2, "john@example.com", new DateTime(2026, 4, 12, 21, 32, 31, 205, DateTimeKind.Utc).AddTicks(9666), "John Doe", 0 },
                    { 3, "jane@example.com", new DateTime(2026, 4, 13, 16, 32, 31, 205, DateTimeKind.Utc).AddTicks(9732), "Jane Smith", 2 },
                    { 4, "ivan@example.com", new DateTime(2026, 4, 13, 21, 32, 31, 205, DateTimeKind.Utc).AddTicks(9746), "Ivan Ivanov", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
