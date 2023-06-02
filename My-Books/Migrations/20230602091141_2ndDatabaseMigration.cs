using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Books.Migrations
{
    public partial class _2ndDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genere",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genere",
                table: "Books");
        }
    }
}
