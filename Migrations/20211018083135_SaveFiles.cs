using Microsoft.EntityFrameworkCore.Migrations;

namespace Tamplate.DAL.Migrations
{
    public partial class SaveFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CvUrl",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CvUrl",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Employee");
        }
    }
}
