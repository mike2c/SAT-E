using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ColumnRolIdAddedToSource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Source",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Source_RolId",
                table: "Source",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Source_Rol_RolId",
                table: "Source",
                column: "RolId",
                principalTable: "Rol",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Source_Rol_RolId",
                table: "Source");

            migrationBuilder.DropIndex(
                name: "IX_Source_RolId",
                table: "Source");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Source");
        }
    }
}
