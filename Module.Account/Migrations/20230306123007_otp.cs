using Microsoft.EntityFrameworkCore.Migrations;

namespace Module.Account.Migrations
{
    public partial class otp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Account",
                table: "PermissionRoles",
                keyColumn: "Id",
                keyValue: new Guid("4429b7d1-e8c4-4471-8dc1-e3a179495582"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "PermissionRoles",
                keyColumn: "Id",
                keyValue: new Guid("47fdeb07-8026-48d5-a253-2de2980913b2"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "PermissionRoles",
                keyColumn: "Id",
                keyValue: new Guid("53da8352-c9dc-4bea-be3a-271260ece393"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2e3d6722-6feb-4c6c-9580-62ef0c204d0c"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("efc633f6-c345-4f0b-913b-1267ef5ca566"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2abb0db3-7487-4b31-8743-244eb495dac0"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5d082e58-e265-44a7-afeb-d9d2ba69be5c"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("8a50b45b-c894-4753-8516-5a23b960499d"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7366e68-08a6-48cc-b748-09c6c963b988"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("ee145ad2-03b6-4b44-a547-720cd1e12aaf"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30a75876-75c9-400f-a78c-5d234b167026"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56dbf710-dac2-47df-9a35-6b341baceee1"));

            migrationBuilder.CreateTable(
                name: "VerfiyCodes",
                schema: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VirfeyCode = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_VerfiyCodes", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Account",
                table: "PermissionRoles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "IsActive", "IsDeleted", "PermissionId", "RoleId", "UpadtedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2933273f-78d0-4d84-abde-3f08728dcef8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("ee58a818-ad49-4819-b208-cb8454b2a518"), new Guid("ac6c54cc-1f5c-405a-a88b-7c2fbdc9c803"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a17b2943-1e2c-40d8-862d-7c0543a17130"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("ee58a818-ad49-4819-b208-cb8454b2a518"), new Guid("86e20417-65f0-4e49-9283-1b773e6d3f9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bacffe86-0106-421f-854e-ec3f76941f40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("fa76e0fb-3959-455a-a6ae-0a0f10a00195"), new Guid("86e20417-65f0-4e49-9283-1b773e6d3f9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                schema: "Account",
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "IsActive", "IsDeleted", "NameAr", "NameEn", "UpadtedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("ee58a818-ad49-4819-b208-cb8454b2a518"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, "صلاحية استخدام الارشيف", "Archive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fa76e0fb-3959-455a-a6ae-0a0f10a00195"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, "صلاحية المدير", "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                schema: "Account",
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "IsActive", "IsDeleted", "NameAr", "NameEn", "UpadtedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("86e20417-65f0-4e49-9283-1b773e6d3f9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, "صلاحية المدير", "AdminRole", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ac6c54cc-1f5c-405a-a88b-7c2fbdc9c803"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, "صلاحية مستخدم", "BasicRole", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                schema: "Account",
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "IsActive", "IsDeleted", "RoleId", "UpadtedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("9d1aaca9-5a22-4da6-923b-938c59aef3af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("ac6c54cc-1f5c-405a-a88b-7c2fbdc9c803"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("8e0c20bd-b8ef-4c70-af20-b05014736118") },
                    { new Guid("b55a8783-9717-4389-9ecb-6c7a22d6c92b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("ac6c54cc-1f5c-405a-a88b-7c2fbdc9c803"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("84b83856-7558-48c4-ba37-26ecd65e9318") },
                    { new Guid("d7e70561-f21c-423a-a3a3-313255d6f775"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("86e20417-65f0-4e49-9283-1b773e6d3f9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("84b83856-7558-48c4-ba37-26ecd65e9318") }
                });

            migrationBuilder.InsertData(
                schema: "Account",
                table: "Users",
                columns: new[] { "Id", "CityId", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "Email", "IsActive", "IsDeleted", "Password", "Phone", "UpadtedAt", "UpdatedBy", "UserName", "UserType", "VendorId" },
                values: new object[,]
                {
                    { new Guid("84b83856-7558-48c4-ba37-26ecd65e9318"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Admin@Admon.com", false, false, "Zmz85diIPmR3ygkO9kNUwQ==", "123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Admin", "Admin", null },
                    { new Guid("8e0c20bd-b8ef-4c70-af20-b05014736118"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Basic@Basic.com", false, false, "lUB3OZqa9U9DS8HKkO0x5A==", "123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Basic", "Buyer", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VerfiyCodes",
                schema: "Account");

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "PermissionRoles",
                keyColumn: "Id",
                keyValue: new Guid("2933273f-78d0-4d84-abde-3f08728dcef8"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "PermissionRoles",
                keyColumn: "Id",
                keyValue: new Guid("a17b2943-1e2c-40d8-862d-7c0543a17130"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "PermissionRoles",
                keyColumn: "Id",
                keyValue: new Guid("bacffe86-0106-421f-854e-ec3f76941f40"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ee58a818-ad49-4819-b208-cb8454b2a518"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fa76e0fb-3959-455a-a6ae-0a0f10a00195"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("86e20417-65f0-4e49-9283-1b773e6d3f9e"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ac6c54cc-1f5c-405a-a88b-7c2fbdc9c803"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("9d1aaca9-5a22-4da6-923b-938c59aef3af"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("b55a8783-9717-4389-9ecb-6c7a22d6c92b"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7e70561-f21c-423a-a3a3-313255d6f775"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84b83856-7558-48c4-ba37-26ecd65e9318"));

            migrationBuilder.DeleteData(
                schema: "Account",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e0c20bd-b8ef-4c70-af20-b05014736118"));

            migrationBuilder.InsertData(
                schema: "Account",
                table: "PermissionRoles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "IsActive", "IsDeleted", "PermissionId", "RoleId", "UpadtedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("53da8352-c9dc-4bea-be3a-271260ece393"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("2e3d6722-6feb-4c6c-9580-62ef0c204d0c"), new Guid("2abb0db3-7487-4b31-8743-244eb495dac0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("47fdeb07-8026-48d5-a253-2de2980913b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("2e3d6722-6feb-4c6c-9580-62ef0c204d0c"), new Guid("5d082e58-e265-44a7-afeb-d9d2ba69be5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4429b7d1-e8c4-4471-8dc1-e3a179495582"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("efc633f6-c345-4f0b-913b-1267ef5ca566"), new Guid("5d082e58-e265-44a7-afeb-d9d2ba69be5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                schema: "Account",
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "IsActive", "IsDeleted", "NameAr", "NameEn", "UpadtedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2e3d6722-6feb-4c6c-9580-62ef0c204d0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, "صلاحية استخدام الارشيف", "Archive", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("efc633f6-c345-4f0b-913b-1267ef5ca566"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, "صلاحية المدير", "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                schema: "Account",
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "IsActive", "IsDeleted", "NameAr", "NameEn", "UpadtedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5d082e58-e265-44a7-afeb-d9d2ba69be5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, "صلاحية المدير", "AdminRole", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2abb0db3-7487-4b31-8743-244eb495dac0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, "صلاحية مستخدم", "BasicRole", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                schema: "Account",
                table: "UserRoles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "IsActive", "IsDeleted", "RoleId", "UpadtedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("d7366e68-08a6-48cc-b748-09c6c963b988"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("2abb0db3-7487-4b31-8743-244eb495dac0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("30a75876-75c9-400f-a78c-5d234b167026") },
                    { new Guid("ee145ad2-03b6-4b44-a547-720cd1e12aaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("2abb0db3-7487-4b31-8743-244eb495dac0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("56dbf710-dac2-47df-9a35-6b341baceee1") },
                    { new Guid("8a50b45b-c894-4753-8516-5a23b960499d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, false, false, new Guid("5d082e58-e265-44a7-afeb-d9d2ba69be5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("56dbf710-dac2-47df-9a35-6b341baceee1") }
                });

            migrationBuilder.InsertData(
                schema: "Account",
                table: "Users",
                columns: new[] { "Id", "CityId", "CreatedAt", "CreatedBy", "DescribtionAr", "DescribtionEn", "Email", "IsActive", "IsDeleted", "Password", "Phone", "UpadtedAt", "UpdatedBy", "UserName", "UserType", "VendorId" },
                values: new object[,]
                {
                    { new Guid("56dbf710-dac2-47df-9a35-6b341baceee1"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Admin@Admon.com", false, false, "Zmz85diIPmR3ygkO9kNUwQ==", "123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Admin", "Admin", null },
                    { new Guid("30a75876-75c9-400f-a78c-5d234b167026"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Basic@Basic.com", false, false, "lUB3OZqa9U9DS8HKkO0x5A==", "123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Basic", "Buyer", null }
                });
        }
    }
}