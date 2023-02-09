using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShop.Infrastructure.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedOn", "ModifiedOn", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32644b40-8958-4f7d-a0c1-5eaa91ae497e", "f5741340-d074-437e-9458-49b6d6dbc0f0", new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8682), null, "User", "USER" },
                    { "b054a395-079b-452e-a440-68231c633323", "8c2a226d-0072-48e5-a2c5-f045e64e5f74", new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8654), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "25a6dc8b-a212-4cd8-9b62-efcdea0c7ab1", 0, "706fc336-cd42-40d8-84ad-057a6dae5c9a", new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8876), "admin@gmail.bg", true, "Admin", "Admin", false, null, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJubwetbC1THGOQJ58REjOopO7QsT4kYR5KLYGkdEaX6pKNlIykFndD7qTjkUVTQrg==", null, false, "055a179f-3292-454d-85ab-090433ae4c55", false, "admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedOn", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8579), null, false, null, "Components" },
                    { new Guid("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8565), null, false, null, "Smartphone" },
                    { new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8584), null, false, null, "Game zone" },
                    { new Guid("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8518), null, false, null, "Laptops" },
                    { new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8582), null, false, null, "Peripherals" },
                    { new Guid("7858db3b-3299-493a-9d87-3830b4f603bc"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8563), null, false, null, "Accessories" },
                    { new Guid("796209de-79b4-4ca5-9b08-f2c4306ff387"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8560), null, false, null, "Computers" },
                    { new Guid("a211c484-8fb5-4f18-a87e-b2e30101fc67"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8567), null, false, null, "Tablets" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b054a395-079b-452e-a440-68231c633323", "25a6dc8b-a212-4cd8-9b62-efcdea0c7ab1" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedOn", "IsDeleted", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("0e0599a4-2854-451e-bc19-69c5e5a7eca0"), new Guid("a211c484-8fb5-4f18-a87e-b2e30101fc67"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8765), null, false, null, "Graphics Tablets" },
                    { new Guid("180538ac-f70f-498f-9a83-454ef8a85a73"), new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8802), null, false, null, "Gaming Monitor" },
                    { new Guid("1a6b32fb-55f5-4231-a1d7-b5cf564cc715"), new Guid("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8754), null, false, null, "Smartphones" },
                    { new Guid("1d38b388-5eb0-4bb3-8279-c18018b36428"), new Guid("796209de-79b4-4ca5-9b08-f2c4306ff387"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8742), null, false, null, "Computers" },
                    { new Guid("269085b4-e4cc-4dd4-bad0-7eac9fea98ac"), new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8792), null, false, null, "Monitor" },
                    { new Guid("3c1d177f-f171-4a09-a86d-5ea6f0f818c6"), new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8790), null, false, null, "Web Camera" },
                    { new Guid("42041daf-22b3-40b7-9d8b-a9723518abaf"), new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8773), null, false, null, "Computer Processor" },
                    { new Guid("437b2ac1-88f4-461c-a929-c2194a544950"), new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8800), null, false, null, "Gaming Headphones" },
                    { new Guid("506449d5-e28b-43be-9882-4739211dced9"), new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8768), null, false, null, "SSD" },
                    { new Guid("840bee94-6ed7-40ee-a7bc-2fa09c0726c9"), new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8778), null, false, null, "Memory" },
                    { new Guid("9c5285d2-615b-4666-9319-e3817a572ca5"), new Guid("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8757), null, false, null, "Smartphones Apple" },
                    { new Guid("9dfcb19f-3030-43b0-b82e-6f116826f274"), new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8787), null, false, null, "Headphones" },
                    { new Guid("a7276329-f79a-42e1-a2c3-8aa64fc943bd"), new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8771), null, false, null, "HDD" },
                    { new Guid("b118ffb5-e5ea-4de4-94ed-d399b916087b"), new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8780), null, false, null, "Keyboard" },
                    { new Guid("b262e059-66bc-40ec-8cae-5693a8ae2d90"), new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8795), null, false, null, "Gaming Keyboard" },
                    { new Guid("be9e90b4-c00d-451b-94ea-ad1b55d2c9f9"), new Guid("796209de-79b4-4ca5-9b08-f2c4306ff387"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8745), null, false, null, "Gaming Computers" },
                    { new Guid("c28b04e4-255b-4ca7-9110-55eb575fef55"), new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8797), null, false, null, "Gaming Mause" },
                    { new Guid("c46cd764-c7bb-4f2f-ba25-ac4c110958bb"), new Guid("7858db3b-3299-493a-9d87-3830b4f603bc"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8748), null, false, null, "Laptop Batteries" },
                    { new Guid("cce85b6f-b9a7-4be4-a0af-73ed8ec18cc7"), new Guid("7858db3b-3299-493a-9d87-3830b4f603bc"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8751), null, false, null, "Laptop Bags" },
                    { new Guid("ce674d7b-013b-4efc-a5d1-0951b488ddeb"), new Guid("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8730), null, false, null, "Laptops" },
                    { new Guid("dfa0476d-9531-4865-914b-f1551f473129"), new Guid("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8739), null, false, null, "Gaming Laptops" },
                    { new Guid("e498e56f-d873-405e-b983-dc48e2309b06"), new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8783), null, false, null, "Mause" },
                    { new Guid("ed8afc98-25ff-4b22-a934-e5e19c2b405b"), new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8776), null, false, null, "Video Card" },
                    { new Guid("f0adbb23-4d6a-45b8-8056-1695948c63a4"), new Guid("a211c484-8fb5-4f18-a87e-b2e30101fc67"), new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8759), null, false, null, "Tablets" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32644b40-8958-4f7d-a0c1-5eaa91ae497e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b054a395-079b-452e-a440-68231c633323", "25a6dc8b-a212-4cd8-9b62-efcdea0c7ab1" });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e0599a4-2854-451e-bc19-69c5e5a7eca0"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("180538ac-f70f-498f-9a83-454ef8a85a73"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a6b32fb-55f5-4231-a1d7-b5cf564cc715"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d38b388-5eb0-4bb3-8279-c18018b36428"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("269085b4-e4cc-4dd4-bad0-7eac9fea98ac"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c1d177f-f171-4a09-a86d-5ea6f0f818c6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("42041daf-22b3-40b7-9d8b-a9723518abaf"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("437b2ac1-88f4-461c-a929-c2194a544950"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("506449d5-e28b-43be-9882-4739211dced9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("840bee94-6ed7-40ee-a7bc-2fa09c0726c9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c5285d2-615b-4666-9319-e3817a572ca5"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9dfcb19f-3030-43b0-b82e-6f116826f274"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7276329-f79a-42e1-a2c3-8aa64fc943bd"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b118ffb5-e5ea-4de4-94ed-d399b916087b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b262e059-66bc-40ec-8cae-5693a8ae2d90"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("be9e90b4-c00d-451b-94ea-ad1b55d2c9f9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c28b04e4-255b-4ca7-9110-55eb575fef55"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c46cd764-c7bb-4f2f-ba25-ac4c110958bb"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cce85b6f-b9a7-4be4-a0af-73ed8ec18cc7"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce674d7b-013b-4efc-a5d1-0951b488ddeb"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dfa0476d-9531-4865-914b-f1551f473129"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e498e56f-d873-405e-b983-dc48e2309b06"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed8afc98-25ff-4b22-a934-e5e19c2b405b"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0adbb23-4d6a-45b8-8056-1695948c63a4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b054a395-079b-452e-a440-68231c633323");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25a6dc8b-a212-4cd8-9b62-efcdea0c7ab1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7858db3b-3299-493a-9d87-3830b4f603bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("796209de-79b4-4ca5-9b08-f2c4306ff387"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a211c484-8fb5-4f18-a87e-b2e30101fc67"));
        }
    }
}
