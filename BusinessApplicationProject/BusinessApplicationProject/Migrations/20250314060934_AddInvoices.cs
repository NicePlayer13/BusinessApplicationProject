using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessApplicationProject.Migrations
{
    /// <inheritdoc />
    public partial class AddInvoices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId1",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OrderId1",
                table: "Invoices",
                column: "OrderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Orders_OrderId1",
                table: "Invoices",
                column: "OrderId1",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Orders_OrderId1",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_OrderId1",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "Invoices");
        }
    }
}
