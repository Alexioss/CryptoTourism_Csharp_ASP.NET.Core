using Microsoft.EntityFrameworkCore.Migrations;

namespace Cryptotourism.Data.Migrations
{
    public partial class carousel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl2",
                table: "Experiences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl3",
                table: "Experiences",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl2",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ImageUrl3",
                table: "Experiences");
        }
    }
}
