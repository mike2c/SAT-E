using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class TechnicalAssistanceAlternateKeyRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TechnicalAssistanceId",
                table: "TechnicalAssistance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TechnicalAssistanceId",
                table: "TechnicalAssistance",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
