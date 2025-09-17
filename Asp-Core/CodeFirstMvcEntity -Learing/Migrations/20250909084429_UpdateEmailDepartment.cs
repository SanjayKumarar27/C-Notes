using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcEntityCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmailDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Emails",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "department",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emails",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "department",
                table: "Students");
        }
    }
}
