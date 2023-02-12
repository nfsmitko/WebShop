using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShop.Infrastructure.Migrations
{
    public partial class ChangingProductDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "ProductDescriptions");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductDescriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "ProductDescriptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductDescriptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "ProductDescriptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32644b40-8958-4f7d-a0c1-5eaa91ae497e",
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "61e4b708-ac3d-4b95-a372-63f8de1f603a", new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b054a395-079b-452e-a440-68231c633323",
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "5ba53336-0d84-4e75-a25c-19bdf2d87784", new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25a6dc8b-a212-4cd8-9b62-efcdea0c7ab1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5df93a9-350c-414c-89ab-825be76bc720", new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1073), "AQAAAAEAACcQAAAAEM+o1oQX8MZQXjoRnC3n/k2fuqr6nWlmyBIwzcRrc8xXkS+BC13kLfsHBAA3nDsFRQ==", "e1ac7b75-6306-459e-bd28-7719eaf8328e" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7858db3b-3299-493a-9d87-3830b4f603bc"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("796209de-79b4-4ca5-9b08-f2c4306ff387"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a211c484-8fb5-4f18-a87e-b2e30101fc67"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e0599a4-2854-451e-bc19-69c5e5a7eca0"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("180538ac-f70f-498f-9a83-454ef8a85a73"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a6b32fb-55f5-4231-a1d7-b5cf564cc715"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d38b388-5eb0-4bb3-8279-c18018b36428"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("269085b4-e4cc-4dd4-bad0-7eac9fea98ac"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c1d177f-f171-4a09-a86d-5ea6f0f818c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("42041daf-22b3-40b7-9d8b-a9723518abaf"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("437b2ac1-88f4-461c-a929-c2194a544950"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("506449d5-e28b-43be-9882-4739211dced9"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("840bee94-6ed7-40ee-a7bc-2fa09c0726c9"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c5285d2-615b-4666-9319-e3817a572ca5"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9dfcb19f-3030-43b0-b82e-6f116826f274"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7276329-f79a-42e1-a2c3-8aa64fc943bd"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b118ffb5-e5ea-4de4-94ed-d399b916087b"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b262e059-66bc-40ec-8cae-5693a8ae2d90"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("be9e90b4-c00d-451b-94ea-ad1b55d2c9f9"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c28b04e4-255b-4ca7-9110-55eb575fef55"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c46cd764-c7bb-4f2f-ba25-ac4c110958bb"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cce85b6f-b9a7-4be4-a0af-73ed8ec18cc7"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce674d7b-013b-4efc-a5d1-0951b488ddeb"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dfa0476d-9531-4865-914b-f1551f473129"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e498e56f-d873-405e-b983-dc48e2309b06"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed8afc98-25ff-4b22-a934-e5e19c2b405b"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0adbb23-4d6a-45b8-8056-1695948c63a4"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 12, 20, 37, 47, 334, DateTimeKind.Local).AddTicks(940));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ProductDescriptions");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "ProductDescriptions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductDescriptions");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "ProductDescriptions");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ProductDescriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32644b40-8958-4f7d-a0c1-5eaa91ae497e",
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "f5741340-d074-437e-9458-49b6d6dbc0f0", new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b054a395-079b-452e-a440-68231c633323",
                columns: new[] { "ConcurrencyStamp", "CreatedOn" },
                values: new object[] { "8c2a226d-0072-48e5-a2c5-f045e64e5f74", new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25a6dc8b-a212-4cd8-9b62-efcdea0c7ab1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "706fc336-cd42-40d8-84ad-057a6dae5c9a", new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8876), "AQAAAAEAACcQAAAAEJubwetbC1THGOQJ58REjOopO7QsT4kYR5KLYGkdEaX6pKNlIykFndD7qTjkUVTQrg==", "055a179f-3292-454d-85ab-090433ae4c55" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00b8b863-7f19-4eb5-8460-c68417db3496"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56c40de8-294a-453e-82d1-5d055bed3e6b"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7858db3b-3299-493a-9d87-3830b4f603bc"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("796209de-79b4-4ca5-9b08-f2c4306ff387"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a211c484-8fb5-4f18-a87e-b2e30101fc67"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0e0599a4-2854-451e-bc19-69c5e5a7eca0"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("180538ac-f70f-498f-9a83-454ef8a85a73"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1a6b32fb-55f5-4231-a1d7-b5cf564cc715"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d38b388-5eb0-4bb3-8279-c18018b36428"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("269085b4-e4cc-4dd4-bad0-7eac9fea98ac"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3c1d177f-f171-4a09-a86d-5ea6f0f818c6"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("42041daf-22b3-40b7-9d8b-a9723518abaf"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("437b2ac1-88f4-461c-a929-c2194a544950"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("506449d5-e28b-43be-9882-4739211dced9"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("840bee94-6ed7-40ee-a7bc-2fa09c0726c9"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c5285d2-615b-4666-9319-e3817a572ca5"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9dfcb19f-3030-43b0-b82e-6f116826f274"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7276329-f79a-42e1-a2c3-8aa64fc943bd"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b118ffb5-e5ea-4de4-94ed-d399b916087b"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("b262e059-66bc-40ec-8cae-5693a8ae2d90"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("be9e90b4-c00d-451b-94ea-ad1b55d2c9f9"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c28b04e4-255b-4ca7-9110-55eb575fef55"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c46cd764-c7bb-4f2f-ba25-ac4c110958bb"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("cce85b6f-b9a7-4be4-a0af-73ed8ec18cc7"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ce674d7b-013b-4efc-a5d1-0951b488ddeb"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dfa0476d-9531-4865-914b-f1551f473129"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("e498e56f-d873-405e-b983-dc48e2309b06"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ed8afc98-25ff-4b22-a934-e5e19c2b405b"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0adbb23-4d6a-45b8-8056-1695948c63a4"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 9, 20, 13, 20, 57, DateTimeKind.Local).AddTicks(8759));
        }
    }
}
