using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace prn211_demo.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    cus_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cus_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cus_gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cus_birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cus_address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.cus_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
