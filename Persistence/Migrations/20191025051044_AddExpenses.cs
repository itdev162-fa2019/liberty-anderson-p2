using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ID", "Amount", "Category", "Date" },
                values: new object[] { 1, 25.32m, "Entertainment", new DateTime(2019, 10, 25, 0, 10, 44, 400, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ID", "Amount", "Category", "Date" },
                values: new object[] { 2, 78.65m, "Food", new DateTime(2019, 10, 25, 0, 10, 44, 402, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ID", "Amount", "Category", "Date" },
                values: new object[] { 3, 152.26m, "Bills", new DateTime(2019, 10, 25, 0, 10, 44, 402, DateTimeKind.Local).AddTicks(2456) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Value1" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Value2" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Value3" });
        }
    }
}
