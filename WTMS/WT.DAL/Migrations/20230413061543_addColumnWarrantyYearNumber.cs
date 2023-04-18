using Microsoft.EntityFrameworkCore.Migrations;

namespace WT.DAL.Migrations
{
    public partial class addColumnWarrantyYearNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "WarrantyYearNumber",
                table: "Products",
                type: "tinyint",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WarrantyYearNumber",
                table: "Products");
        }
    }
}
