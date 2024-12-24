using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_forumitem1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ForumItems",
                columns: new[] { "Id", "Answer", "Name", "Question" },
                values: new object[] { 4, "ответ", "тема 4", "вопрос" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ForumItems",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
