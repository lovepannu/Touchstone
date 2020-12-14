using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Touchstone.Migrations
{
    public partial class Touchstone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    branchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branchName = table.Column<string>(nullable: true),
                    branchAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.branchID);
                });

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    batchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    batchName = table.Column<string>(nullable: true),
                    startDate = table.Column<DateTime>(nullable: false),
                    endDate = table.Column<DateTime>(nullable: false),
                    courseCost = table.Column<string>(nullable: true),
                    branch_ID = table.Column<int>(nullable: false),
                    branch_objbranchID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.batchID);
                    table.ForeignKey(
                        name: "FK_Batch_Branch_branch_objbranchID",
                        column: x => x.branch_objbranchID,
                        principalTable: "Branch",
                        principalColumn: "branchID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    tutorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tutorName = table.Column<string>(nullable: true),
                    tutorEmail = table.Column<string>(nullable: true),
                    tutorMobile = table.Column<int>(nullable: false),
                    tutorAddress = table.Column<string>(nullable: true),
                    branch_ID = table.Column<int>(nullable: false),
                    branch_objbranchID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.tutorID);
                    table.ForeignKey(
                        name: "FK_Tutor_Branch_branch_objbranchID",
                        column: x => x.branch_objbranchID,
                        principalTable: "Branch",
                        principalColumn: "branchID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    studentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentName = table.Column<string>(nullable: true),
                    studentMobile = table.Column<int>(nullable: false),
                    studentEmail = table.Column<string>(nullable: true),
                    studentAddress = table.Column<string>(nullable: true),
                    tutor_ID = table.Column<int>(nullable: false),
                    tutor_objtutorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.studentID);
                    table.ForeignKey(
                        name: "FK_Student_Tutor_tutor_objtutorID",
                        column: x => x.tutor_objtutorID,
                        principalTable: "Tutor",
                        principalColumn: "tutorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batch_branch_objbranchID",
                table: "Batch",
                column: "branch_objbranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_tutor_objtutorID",
                table: "Student",
                column: "tutor_objtutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_branch_objbranchID",
                table: "Tutor",
                column: "branch_objbranchID");
            var sqlFile = Path.Combine(".\\DatabaseScript", @"data.sql");
                migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "Branch");
        }
    }
}
