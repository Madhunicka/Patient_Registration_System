using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patient_Registration_System.Migrations.Password
{
    /// <inheritdoc />
    public partial class t6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Passwords",
                table: "Passwords",
                newName: "Passwrd");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Passwrd",
                table: "Passwords",
                newName: "Passwords");
        }
    }
}
