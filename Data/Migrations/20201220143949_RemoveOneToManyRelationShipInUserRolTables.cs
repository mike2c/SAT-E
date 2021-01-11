using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class RemoveOneToManyRelationShipInUserRolTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_RolId",
                table: "User",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Rol_RolId",
                table: "User",
                column: "RolId",
                principalTable: "Rol",
                principalColumn: "RolId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Rol_RolId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RolId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "User");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RolesRolId = table.Column<int>(type: "int", nullable: false),
                    UsersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RolesRolId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Rol_RolesRolId",
                        column: x => x.RolesRolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UsersUserId",
                table: "UserRoles",
                column: "UsersUserId");
        }
    }
}
