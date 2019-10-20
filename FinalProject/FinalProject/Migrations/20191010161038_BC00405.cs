using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class BC00405 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "News",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 38, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2019, 10, 10, 20, 10, 38, 39, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "News");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddDate",
                value: new DateTime(2019, 10, 4, 19, 50, 5, 963, DateTimeKind.Local));
        }
    }
}
