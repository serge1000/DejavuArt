using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Commercial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<char>(
                name: "Commercial",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: '0');
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Commercial",
                table: "Products");
        }
    }
}
