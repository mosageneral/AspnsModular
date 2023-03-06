using Microsoft.EntityFrameworkCore.Migrations;

namespace Module.Financial.Migrations
{
    public partial class inv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DeliverySubTWare",
                schema: "Financial",
                table: "InvoiceB2Cs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "OverHead",
                schema: "Financial",
                table: "InvoiceB2Cs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliverySubTWare",
                schema: "Financial",
                table: "InvoiceB2Cs");

            migrationBuilder.DropColumn(
                name: "OverHead",
                schema: "Financial",
                table: "InvoiceB2Cs");
        }
    }
}
