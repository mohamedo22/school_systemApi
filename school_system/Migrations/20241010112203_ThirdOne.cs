using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_system.Migrations
{
    /// <inheritdoc />
    public partial class ThirdOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_subjects_subjectId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_subjectId",
                table: "students");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "subjects",
                newName: "subjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "subjectId",
                table: "subjects",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_students_subjectId",
                table: "students",
                column: "subjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_subjects_subjectId",
                table: "students",
                column: "subjectId",
                principalTable: "subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
