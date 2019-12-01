using Microsoft.EntityFrameworkCore.Migrations;

namespace Brspontes_RH_System_Infra.Migrations
{
    public partial class MigrationNewFieldActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Candidates",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Candidates");
        }
    }
}
