using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module.Financial.Migrations
{
    public partial class live : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvoiceB2Cs",
                schema: "Financial",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNumber = table.Column<int>(type: "int", nullable: false),
                    InvoiceSerial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VendorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuyerNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyerNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buyerhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceParts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalBeforeDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAfterDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpadtedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescribtionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescribtionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceB2Cs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItemB2Cs",
                schema: "Financial",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PricePerPart = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpadtedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescribtionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescribtionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItemB2Cs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceB2Cs",
                schema: "Financial");

            migrationBuilder.DropTable(
                name: "InvoiceItemB2Cs",
                schema: "Financial");
        }
    }
}
