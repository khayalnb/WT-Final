 using Microsoft.EntityFrameworkCore.Migrations;

namespace WT.DAL.Migrations
{
    public partial class addColumnBrandIdinBrandTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_OfferCompanies_OfferCompanyId",
                table: "Products");

            migrationBuilder.AlterColumn<byte>(
                name: "WarrantyYearNumber",
                table: "Products",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TextParametr",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OfferCompanyId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Brands",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brands_SubCategoryId",
                table: "Brands",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brands_SubCategories_SubCategoryId",
                table: "Brands",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OfferCompanies_OfferCompanyId",
                table: "Products",
                column: "OfferCompanyId",
                principalTable: "OfferCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brands_SubCategories_SubCategoryId",
                table: "Brands");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OfferCompanies_OfferCompanyId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Brands_SubCategoryId",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Brands");

            migrationBuilder.AlterColumn<byte>(
                name: "WarrantyYearNumber",
                table: "Products",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<string>(
                name: "TextParametr",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "OfferCompanyId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OfferCompanies_OfferCompanyId",
                table: "Products",
                column: "OfferCompanyId",
                principalTable: "OfferCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
