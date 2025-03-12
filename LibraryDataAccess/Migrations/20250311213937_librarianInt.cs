using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class librarianInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1001);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "MemberShipType", "Name", "Password", "Phone", "Role", "Username" },
                values: new object[] { 1001, "librarian1@gmail.com", "None", "Maryam", "$2a$11$m.eypqRo7lKtcVo7QMPDkO9x2hAOwJQp/KEHRSWuYik7jm1N9IuFG", "01012345678", "Librarian", "maryam" });
        }
    }
}
