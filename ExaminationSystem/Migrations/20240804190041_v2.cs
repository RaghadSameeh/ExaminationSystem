using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Questions_QuestionID",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Exams_ExamID",
                table: "ExamQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Questions_QuestionID",
                table: "ExamQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_CourseID",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Exams_ExamID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_StudentID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourse_Courses_CourseID",
                table: "StudentsCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourse_Students_StudentID",
                table: "StudentsCourse");

            migrationBuilder.AddColumn<int>(
                name: "MaxScore",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StudentAnswers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ChoiceId = table.Column<int>(type: "int", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAnswers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentAnswers_Choices_ChoiceId",
                        column: x => x.ChoiceId,
                        principalTable: "Choices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentAnswers_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentAnswers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsExams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsExams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentsExams_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsExams_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_InstructorID",
                table: "Questions",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_InstructorID",
                table: "Exams",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_ChoiceId",
                table: "StudentAnswers",
                column: "ChoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_ExamId",
                table: "StudentAnswers",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_QuestionId",
                table: "StudentAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_StudentId",
                table: "StudentAnswers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsExams_ExamId",
                table: "StudentsExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsExams_StudentId",
                table: "StudentsExams",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Questions_QuestionID",
                table: "Choices",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorID",
                table: "Courses",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Exams_ExamID",
                table: "ExamQuestions",
                column: "ExamID",
                principalTable: "Exams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Questions_QuestionID",
                table: "ExamQuestions",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_CourseID",
                table: "Exams",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Instructors_InstructorID",
                table: "Exams",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Instructors_InstructorID",
                table: "Questions",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Exams_ExamID",
                table: "Results",
                column: "ExamID",
                principalTable: "Exams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_StudentID",
                table: "Results",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourse_Courses_CourseID",
                table: "StudentsCourse",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourse_Students_StudentID",
                table: "StudentsCourse",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Questions_QuestionID",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Exams_ExamID",
                table: "ExamQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Questions_QuestionID",
                table: "ExamQuestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_CourseID",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Instructors_InstructorID",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Instructors_InstructorID",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Exams_ExamID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Students_StudentID",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourse_Courses_CourseID",
                table: "StudentsCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourse_Students_StudentID",
                table: "StudentsCourse");

            migrationBuilder.DropTable(
                name: "StudentAnswers");

            migrationBuilder.DropTable(
                name: "StudentsExams");

            migrationBuilder.DropIndex(
                name: "IX_Questions_InstructorID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Exams_InstructorID",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "MaxScore",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Exams");

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Questions_QuestionID",
                table: "Choices",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorID",
                table: "Courses",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Exams_ExamID",
                table: "ExamQuestions",
                column: "ExamID",
                principalTable: "Exams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Questions_QuestionID",
                table: "ExamQuestions",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_CourseID",
                table: "Exams",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Exams_ExamID",
                table: "Results",
                column: "ExamID",
                principalTable: "Exams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Students_StudentID",
                table: "Results",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourse_Courses_CourseID",
                table: "StudentsCourse",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourse_Students_StudentID",
                table: "StudentsCourse",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
