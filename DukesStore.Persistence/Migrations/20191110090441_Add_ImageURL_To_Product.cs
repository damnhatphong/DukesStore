using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DukesStore.Persistence.Migrations
{
    public partial class Add_ImageURL_To_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                schema: "production",
                table: "products",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 1,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 2,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 3,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 4,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 5,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 6,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "products",
                keyColumn: "product_id",
                keyValue: 1,
                column: "product_description",
                value: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");

            migrationBuilder.UpdateData(
                schema: "production",
                table: "products",
                keyColumn: "product_id",
                keyValue: 2,
                column: "product_description",
                value: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                schema: "production",
                table: "products");

            migrationBuilder.UpdateData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 1,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 2,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 3,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 4,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 5,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 6,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "products",
                keyColumn: "product_id",
                keyValue: 1,
                column: "product_description",
                value: null);

            migrationBuilder.UpdateData(
                schema: "production",
                table: "products",
                keyColumn: "product_id",
                keyValue: 2,
                column: "product_description",
                value: null);
        }
    }
}
