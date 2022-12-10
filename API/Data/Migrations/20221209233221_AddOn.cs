using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class AddOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<char>(
                name: "AddOn",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: '0');
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddOn",
                table: "Products");
        }
    }
}
