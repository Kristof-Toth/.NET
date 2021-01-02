using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkyBook.DataAccess.Migrations
{
    public partial class AddCompanyToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Company_City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsAuthorizedCompany",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company_Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company_PostalCode",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company_State",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company_StreetAddress",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company_City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsAuthorizedCompany",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Company_Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Company_PostalCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Company_State",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Company_StreetAddress",
                table: "AspNetUsers");
        }
    }
}
