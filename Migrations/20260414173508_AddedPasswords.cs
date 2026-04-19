using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Itransition_Task4.Migrations
{
    /// <inheritdoc />
    public partial class AddedPasswords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HashedPassword",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashedPassword", "LastLoginTime" },
                values: new object[] { "a", new DateTime(2026, 4, 14, 17, 35, 7, 714, DateTimeKind.Utc).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HashedPassword", "LastLoginTime" },
                values: new object[] { "b", new DateTime(2026, 4, 13, 17, 35, 7, 714, DateTimeKind.Utc).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HashedPassword", "LastLoginTime" },
                values: new object[] { "c", new DateTime(2026, 4, 14, 12, 35, 7, 714, DateTimeKind.Utc).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HashedPassword", "LastLoginTime" },
                values: new object[] { "d", new DateTime(2026, 4, 14, 17, 35, 7, 714, DateTimeKind.Utc).AddTicks(7632) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HashedPassword",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastLoginTime",
                value: new DateTime(2026, 4, 13, 21, 32, 31, 205, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastLoginTime",
                value: new DateTime(2026, 4, 12, 21, 32, 31, 205, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastLoginTime",
                value: new DateTime(2026, 4, 13, 16, 32, 31, 205, DateTimeKind.Utc).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastLoginTime",
                value: new DateTime(2026, 4, 13, 21, 32, 31, 205, DateTimeKind.Utc).AddTicks(9746));
        }
    }
}
