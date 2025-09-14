using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessApplicationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordHash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
            name: "PasswordHash",
            table: "Customers",
            type: "nvarchar(max)",
            nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
            name: "PasswordHash",
            table: "Customers");
        }
    }
}
