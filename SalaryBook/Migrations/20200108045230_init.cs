using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaryBook.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "salaryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    AddUser = table.Column<string>(nullable: true),
                    AddTime = table.Column<DateTime>(nullable: true),
                    EditUser = table.Column<string>(nullable: true),
                    EditTime = table.Column<DateTime>(nullable: true),
                    TypeCode = table.Column<int>(nullable: false),
                    TypeName = table.Column<string>(nullable: true),
                    TypeDec = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salaryTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "salaryTypes");
        }
    }
}
