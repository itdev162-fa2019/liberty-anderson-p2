using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CreateExpensesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 18, 15, 42, 15, 520, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 18, 15, 42, 15, 524, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 18, 15, 42, 15, 524, DateTimeKind.Local).AddTicks(6658));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 10, 25, 0, 10, 44, 400, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 10, 25, 0, 10, 44, 402, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 10, 25, 0, 10, 44, 402, DateTimeKind.Local).AddTicks(2456));
        }
    }
}
