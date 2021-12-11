using Microsoft.EntityFrameworkCore.Migrations;

namespace ConcessionariaOnline.Migrations
{
    public partial class AddClientIdToCarsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "clientId",
                table: "Cars",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clientId",
                table: "Cars");
        }
    }
}
