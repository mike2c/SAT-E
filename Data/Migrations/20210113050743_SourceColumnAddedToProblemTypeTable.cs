using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SourceColumnAddedToProblemTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SourceId",
                table: "ProblemType",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProblemType_SourceId",
                table: "ProblemType",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProblemType_Source_SourceId",
                table: "ProblemType",
                column: "SourceId",
                principalTable: "Source",
                principalColumn: "SourceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProblemType_Source_SourceId",
                table: "ProblemType");

            migrationBuilder.DropIndex(
                name: "IX_ProblemType_SourceId",
                table: "ProblemType");

            migrationBuilder.DropColumn(
                name: "SourceId",
                table: "ProblemType");
        }
    }
}
