using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurationApp.Migrations
{
    public partial class AddedPersonModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Cuisines",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Cuisines");
        }
    }
}
