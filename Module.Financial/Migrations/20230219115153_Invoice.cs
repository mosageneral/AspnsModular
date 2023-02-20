using Microsoft.EntityFrameworkCore.Migrations;

namespace Module.Financial.Migrations
{
    public partial class Invoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SparePartId",
                schema: "Financial",
                table: "InvoiceItemB2Bs");

            migrationBuilder.RenameColumn(
                name: "SparePartEn",
                schema: "Financial",
                table: "InvoiceItemB2Bs",
                newName: "ItemEn");

            migrationBuilder.RenameColumn(
                name: "SparePartAr",
                schema: "Financial",
                table: "InvoiceItemB2Bs",
                newName: "ItemAr");

            migrationBuilder.AddColumn<string>(
                name: "InvoiceSerial",
                schema: "Financial",
                table: "InvoiceB2Bs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceSerial",
                schema: "Financial",
                table: "InvoiceB2Bs");

            migrationBuilder.RenameColumn(
                name: "ItemEn",
                schema: "Financial",
                table: "InvoiceItemB2Bs",
                newName: "SparePartEn");

            migrationBuilder.RenameColumn(
                name: "ItemAr",
                schema: "Financial",
                table: "InvoiceItemB2Bs",
                newName: "SparePartAr");

            migrationBuilder.AddColumn<int>(
                name: "SparePartId",
                schema: "Financial",
                table: "InvoiceItemB2Bs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
