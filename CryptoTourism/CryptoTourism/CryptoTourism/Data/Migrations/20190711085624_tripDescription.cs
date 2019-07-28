using Microsoft.EntityFrameworkCore.Migrations;

namespace Cryptotourism.Data.Migrations
{
    public partial class tripDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TripDescription",
                table: "Experiences",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TripDescription",
                table: "Experiences");
        }
    }
}
