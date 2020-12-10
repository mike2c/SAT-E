using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CelPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false),
                    RolName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Solution",
                columns: table => new
                {
                    SolutionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolutionName = table.Column<string>(type: "Varchar(45)", maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solution", x => x.SolutionId);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    SourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceName = table.Column<string>(type: "VarChar(45)", maxLength: 45, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.SourceId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "VarChar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "VarChar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "VarChar(45)", maxLength: 45, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Annotation",
                columns: table => new
                {
                    AnnotationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnotationBody = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annotation", x => x.AnnotationId);
                    table.ForeignKey(
                        name: "FK_Annotation_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    AttachmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "VarChar(100)", maxLength: 100, nullable: false),
                    Extension = table.Column<string>(type: "Char(5)", maxLength: 5, nullable: false),
                    Path = table.Column<string>(type: "VarChar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.AttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolutionHistory",
                columns: table => new
                {
                    SolutionHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SolutionDescription = table.Column<string>(type: "text", nullable: false),
                    SolutionId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionHistory", x => x.SolutionHistoryId);
                    table.ForeignKey(
                        name: "FK_SolutionHistory_Solution_SolutionId",
                        column: x => x.SolutionId,
                        principalTable: "Solution",
                        principalColumn: "SolutionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SolutionHistory_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Problem = table.Column<string>(type: "text", nullable: false),
                    TaskDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedTime = table.Column<float>(type: "real", nullable: false),
                    ActualTime = table.Column<float>(type: "real", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    AttendedByUserId = table.Column<int>(type: "int", nullable: true),
                    AssignedByUserId = table.Column<int>(type: "int", nullable: true),
                    AssingedToUserId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    TaskType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Task_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_Source_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Source",
                        principalColumn: "SourceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_User_AssignedByUserId",
                        column: x => x.AssignedByUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_User_AssingedToUserId",
                        column: x => x.AssingedToUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_User_AttendedByUserId",
                        column: x => x.AttendedByUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "SolutionHistoryAttachments",
                columns: table => new
                {
                    AttachmentsAttachmentId = table.Column<int>(type: "int", nullable: false),
                    SolutionHistoriesSolutionHistoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionHistoryAttachments", x => new { x.AttachmentsAttachmentId, x.SolutionHistoriesSolutionHistoryId });
                    table.ForeignKey(
                        name: "FK_SolutionHistoryAttachments_Attachment_AttachmentsAttachmentId",
                        column: x => x.AttachmentsAttachmentId,
                        principalTable: "Attachment",
                        principalColumn: "AttachmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SolutionHistoryAttachments_SolutionHistory_SolutionHistoriesSolutionHistoryId",
                        column: x => x.SolutionHistoriesSolutionHistoryId,
                        principalTable: "SolutionHistory",
                        principalColumn: "SolutionHistoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalAssistance",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    TechnicalAssistanceId = table.Column<int>(type: "int", nullable: false),
                    SolutionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalAssistance", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_TechnicalAssistance_Solution_SolutionId",
                        column: x => x.SolutionId,
                        principalTable: "Solution",
                        principalColumn: "SolutionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TechnicalAssistance_Task_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Task",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Annotation_UserId",
                table: "Annotation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_UserId",
                table: "Attachment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SolutionHistory_SolutionId",
                table: "SolutionHistory",
                column: "SolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_SolutionHistory_UserId",
                table: "SolutionHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SolutionHistoryAttachments_SolutionHistoriesSolutionHistoryId",
                table: "SolutionHistoryAttachments",
                column: "SolutionHistoriesSolutionHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_AssignedByUserId",
                table: "Task",
                column: "AssignedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_AssingedToUserId",
                table: "Task",
                column: "AssingedToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_AttendedByUserId",
                table: "Task",
                column: "AttendedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_EmployeeId",
                table: "Task",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_SourceId",
                table: "Task",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalAssistance_SolutionId",
                table: "TechnicalAssistance",
                column: "SolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UsersUserId",
                table: "UserRoles",
                column: "UsersUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Annotation");

            migrationBuilder.DropTable(
                name: "SolutionHistoryAttachments");

            migrationBuilder.DropTable(
                name: "TechnicalAssistance");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "SolutionHistory");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Solution");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
