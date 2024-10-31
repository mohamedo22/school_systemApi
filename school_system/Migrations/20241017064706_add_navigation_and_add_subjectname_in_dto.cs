using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_system.Migrations
{
    /// <inheritdoc />
    public partial class add_navigation_and_add_subjectname_in_dto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_students_subjectId",
                table: "students",
                column: "subjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_subjects_subjectId",
                table: "students",
                column: "subjectId",
                principalTable: "subjects",
                principalColumn: "subjectId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_subjects_subjectId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_subjectId",
                table: "students");
        }
    }
}
