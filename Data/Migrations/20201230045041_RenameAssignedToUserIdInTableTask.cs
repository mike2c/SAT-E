using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class RenameAssignedToUserIdInTableTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_AssingedToUserId",
                table: "Task");

            migrationBuilder.RenameColumn(
                name: "AssingedToUserId",
                table: "Task",
                newName: "AssignedToUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_AssingedToUserId",
                table: "Task",
                newName: "IX_Task_AssignedToUserId");

            migrationBuilder.AlterColumn<string>(
                name: "TaskName",
                table: "Task",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_AssignedToUserId",
                table: "Task",
                column: "AssignedToUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_User_AssignedToUserId",
                table: "Task");

            migrationBuilder.RenameColumn(
                name: "AssignedToUserId",
                table: "Task",
                newName: "AssingedToUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_AssignedToUserId",
                table: "Task",
                newName: "IX_Task_AssingedToUserId");

            migrationBuilder.AlterColumn<string>(
                name: "TaskName",
                table: "Task",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_User_AssingedToUserId",
                table: "Task",
                column: "AssingedToUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
