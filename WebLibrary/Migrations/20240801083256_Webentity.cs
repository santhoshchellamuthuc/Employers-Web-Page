using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebLibrary.Migrations
{
    public partial class Webentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Webpage",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    brithdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    experience = table.Column<long>(type: "bigint", nullable: false),
                    exceptedsalary = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Webpage", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Webpage");
        }
    }
}
