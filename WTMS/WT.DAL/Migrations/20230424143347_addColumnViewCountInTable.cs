using Microsoft.EntityFrameworkCore.Migrations;

namespace WT.DAL.Migrations
{
    public partial class addColumnViewCountInTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CorporativeSales",
                type: "ntext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CorporativeSales",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "ntext",
                oldNullable: true);
        }
    }
}
