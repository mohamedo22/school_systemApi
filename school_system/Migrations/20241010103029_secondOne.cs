using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace school_system.Migrations
{
    /// <inheritdoc />
    public partial class secondOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "subjectId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_subjects_subjectId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_subjectId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "subjectId",
                table: "students");
        }
    }
}
