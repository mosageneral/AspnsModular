using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module.Archive.Migrations
{
    public partial class fistones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Archive");

            migrationBuilder.CreateTable(
                name: "ArchiveBuildings",
                schema: "Archive",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_ArchiveBuildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArchiveFloors",
                schema: "Archive",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FloorNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloorNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchiveBuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ArchiveFloors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArchiveFloors_ArchiveBuildings_ArchiveBuildingId",
                        column: x => x.ArchiveBuildingId,
                        principalSchema: "Archive",
                        principalTable: "ArchiveBuildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArchiveRooms",
                schema: "Archive",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchiveFloorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ArchiveRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArchiveRooms_ArchiveFloors_ArchiveFloorId",
                        column: x => x.ArchiveFloorId,
                        principalSchema: "Archive",
                        principalTable: "ArchiveFloors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arcivecupboards",
                schema: "Archive",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cupboardNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cupboardNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArchiveRoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Arcivecupboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arcivecupboards_ArchiveRooms_ArchiveRoomId",
                        column: x => x.ArchiveRoomId,
                        principalSchema: "Archive",
                        principalTable: "ArchiveRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArchiveCells",
                schema: "Archive",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CellNameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellNameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArcivecupboardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ArchiveCells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArchiveCells_Arcivecupboards_ArcivecupboardId",
                        column: x => x.ArcivecupboardId,
                        principalSchema: "Archive",
                        principalTable: "Arcivecupboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArchiveCells_ArcivecupboardId",
                schema: "Archive",
                table: "ArchiveCells",
                column: "ArcivecupboardId");

            migrationBuilder.CreateIndex(
                name: "IX_ArchiveFloors_ArchiveBuildingId",
                schema: "Archive",
                table: "ArchiveFloors",
                column: "ArchiveBuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_ArchiveRooms_ArchiveFloorId",
                schema: "Archive",
                table: "ArchiveRooms",
                column: "ArchiveFloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Arcivecupboards_ArchiveRoomId",
                schema: "Archive",
                table: "Arcivecupboards",
                column: "ArchiveRoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchiveCells",
                schema: "Archive");

            migrationBuilder.DropTable(
                name: "Arcivecupboards",
                schema: "Archive");

            migrationBuilder.DropTable(
                name: "ArchiveRooms",
                schema: "Archive");

            migrationBuilder.DropTable(
                name: "ArchiveFloors",
                schema: "Archive");

            migrationBuilder.DropTable(
                name: "ArchiveBuildings",
                schema: "Archive");
        }
    }
}
