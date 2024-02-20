using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveRequestApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dbcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CumulativeLeaveRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeaveType = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalHours = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CumulativeLeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CumulativeLeaveRequests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeaveType = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkflowStatus = table.Column<int>(type: "int", nullable: false),
                    AssignedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsersId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Users_LastModifiedById",
                        column: x => x.LastModifiedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Users_UsersId1",
                        column: x => x.UsersId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    LeaveTypeEnum = table.Column<int>(type: "int", nullable: false),
                    TotalPermission = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RemainderPermission = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CumulativeLeaveRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_CumulativeLeaveRequests_CumulativeLeaveRequestId",
                        column: x => x.CumulativeLeaveRequestId,
                        principalTable: "CumulativeLeaveRequests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FirstName", "IsDeleted", "LastName", "ManagerId", "UserType" },
                values: new object[,]
                {
                    { new Guid("23591451-1cf1-46a5-907a-ee3e52abe394"), new DateTime(2024, 2, 20, 3, 54, 22, 690, DateTimeKind.Local).AddTicks(3267), "kemal.sunal@negzel.net", "Kemal", false, "Sunal", new Guid("59fb152a-2d59-435d-8fc1-cbc35c0f1d82"), 20 },
                    { new Guid("59fb152a-2d59-435d-8fc1-cbc35c0f1d82"), new DateTime(2024, 2, 20, 3, 54, 22, 690, DateTimeKind.Local).AddTicks(3264), "sener.sen@negzel.net ", "Şener", false, "Şen", new Guid("e21cd525-031c-4364-b173-4150a4e18c37"), 10 },
                    { new Guid("e21cd525-031c-4364-b173-4150a4e18c37"), new DateTime(2024, 2, 20, 3, 54, 22, 690, DateTimeKind.Local).AddTicks(3257), "munir.ozkul@negzel.net", "Münir", false, "Özkul", new Guid("00000000-0000-0000-0000-000000000000"), 30 }
                });

            migrationBuilder.InsertData(
                table: "CumulativeLeaveRequests",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "LeaveType", "TotalHours", "UserId", "Year" },
                values: new object[,]
                {
                    { new Guid("7fa9f56c-a54e-49ae-a9bf-2266a449992b"), new DateTime(2024, 2, 20, 3, 54, 22, 689, DateTimeKind.Local).AddTicks(9806), false, 20, 16, new Guid("23591451-1cf1-46a5-907a-ee3e52abe394"), 2023 },
                    { new Guid("85a3bd68-2f6b-49f8-9f03-2cb0eaa54d13"), new DateTime(2024, 2, 20, 3, 54, 22, 689, DateTimeKind.Local).AddTicks(9774), false, 10, 80, new Guid("e21cd525-031c-4364-b173-4150a4e18c37"), 2023 },
                    { new Guid("dc808a4f-8ae8-4d7a-b228-e1cb957f815d"), new DateTime(2024, 2, 20, 3, 54, 22, 689, DateTimeKind.Local).AddTicks(9802), false, 20, 60, new Guid("59fb152a-2d59-435d-8fc1-cbc35c0f1d82"), 2023 },
                    { new Guid("f47b75ae-6318-413c-ab36-ad82d380c0dd"), new DateTime(2024, 2, 20, 3, 54, 22, 689, DateTimeKind.Local).AddTicks(9804), false, 10, 32, new Guid("23591451-1cf1-46a5-907a-ee3e52abe394"), 2023 }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedDate", "CumulativeLeaveRequestId", "IsDeleted", "Message", "UserId" },
                values: new object[,]
                {
                    { new Guid("405287b8-2321-4d22-b96f-15f36afb9b3e"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Kalan AnnualLeave 2 gün ", new Guid("59fb152a-2d59-435d-8fc1-cbc35c0f1d82") },
                    { new Guid("0422b3bb-7618-43d2-b694-3229396d724b"), new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7fa9f56c-a54e-49ae-a9bf-2266a449992b"), false, "Kalan ExcusedAbsence 8 saat", new Guid("23591451-1cf1-46a5-907a-ee3e52abe394") },
                    { new Guid("b89210d0-541f-4718-854a-e0d2d64c9f75"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85a3bd68-2f6b-49f8-9f03-2cb0eaa54d13"), false, "Aşılan AnnualLeave 1 gün", new Guid("e21cd525-031c-4364-b173-4150a4e18c37") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CumulativeLeaveRequests_UserId",
                table: "CumulativeLeaveRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_CreatedByUserId",
                table: "LeaveRequests",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LastModifiedById",
                table: "LeaveRequests",
                column: "LastModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_UsersId",
                table: "LeaveRequests",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_UsersId1",
                table: "LeaveRequests",
                column: "UsersId1");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CumulativeLeaveRequestId",
                table: "Notifications",
                column: "CumulativeLeaveRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_UsersId",
                table: "Permissions",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "CumulativeLeaveRequests");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
