using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Itransition_Task4.Migrations
{
    /// <inheritdoc />
    public partial class FixDynamicDataInSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Statuses",
                table: "Users",
                newName: "Status");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginTime",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationToken",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ResetToken",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConfirmationToken", "HashedPassword", "LastLoginTime", "RegistrationDate", "ResetToken" },
                values: new object[] { null, "$2a$11$u1epTMFLWNZ39L6QNgJqDey.8E5vcmHTspZtuKYxNN8dt7k1XVUuu", new DateTime(2026, 4, 19, 22, 49, 13, 145, DateTimeKind.Utc).AddTicks(9431), new DateTime(2026, 4, 19, 22, 49, 12, 848, DateTimeKind.Utc).AddTicks(1131), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConfirmationToken", "HashedPassword", "LastLoginTime", "RegistrationDate", "ResetToken", "Status" },
                values: new object[] { null, "$2a$11$bJ0xzWrOxlOglTbVIvKFd.eCJH5VrLvAwfsZ2UIe.byEs021hgWQ.", new DateTime(2026, 4, 18, 22, 49, 13, 295, DateTimeKind.Utc).AddTicks(2236), new DateTime(2026, 4, 19, 22, 49, 13, 146, DateTimeKind.Utc).AddTicks(1433), null, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConfirmationToken", "HashedPassword", "LastLoginTime", "RegistrationDate", "ResetToken", "Status" },
                values: new object[] { null, "$2a$11$eYctyqiQnVhP6S3aVXb0xOGaaha/4sYTwiZ2HYHVLoHy5wkXjcF66", new DateTime(2026, 4, 19, 17, 49, 13, 443, DateTimeKind.Utc).AddTicks(6606), new DateTime(2026, 4, 19, 22, 49, 13, 295, DateTimeKind.Utc).AddTicks(2479), null, 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConfirmationToken", "HashedPassword", "LastLoginTime", "RegistrationDate", "ResetToken" },
                values: new object[] { null, "$2a$11$lPsm3NIplxn6pgiqOPSxuuiURX6dYfVYhVB2uSsVp5XwA7J.NHI/q", new DateTime(2026, 4, 16, 22, 49, 13, 593, DateTimeKind.Utc).AddTicks(7017), new DateTime(2026, 4, 19, 22, 49, 13, 443, DateTimeKind.Utc).AddTicks(6849), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ResetToken",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Users",
                newName: "Statuses");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginTime",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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
                columns: new[] { "HashedPassword", "LastLoginTime", "Statuses" },
                values: new object[] { "b", new DateTime(2026, 4, 13, 17, 35, 7, 714, DateTimeKind.Utc).AddTicks(7526), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HashedPassword", "LastLoginTime", "Statuses" },
                values: new object[] { "c", new DateTime(2026, 4, 14, 12, 35, 7, 714, DateTimeKind.Utc).AddTicks(7617), 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HashedPassword", "LastLoginTime" },
                values: new object[] { "d", new DateTime(2026, 4, 14, 17, 35, 7, 714, DateTimeKind.Utc).AddTicks(7632) });
        }
    }
}
