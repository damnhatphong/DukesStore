using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DukesStore.Persistence.Migrations
{
    public partial class Add_Description_To_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 12);

            migrationBuilder.AddColumn<string>(
                name: "product_description",
                schema: "production",
                table: "products",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                schema: "production",
                table: "Currency",
                columns: new[] { "CurrencyId", "CreatedDate", "CurrencyUnit" },
                values: new object[] { 2, new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "VND" });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "categories",
                keyColumn: "category_id",
                keyValue: 4,
                column: "category_name",
                value: "Head Phone");

            migrationBuilder.UpdateData(
                schema: "production",
                table: "categories",
                keyColumn: "category_id",
                keyValue: 5,
                column: "category_name",
                value: "Smart Watch");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "product_description",
                schema: "production",
                table: "products");

            migrationBuilder.UpdateData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                schema: "production",
                table: "Currency",
                columns: new[] { "CurrencyId", "CreatedDate", "CurrencyUnit" },
                values: new object[] { 12, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "VND" });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "categories",
                keyColumn: "category_id",
                keyValue: 4,
                column: "category_name",
                value: "HeadPhone");

            migrationBuilder.UpdateData(
                schema: "production",
                table: "categories",
                keyColumn: "category_id",
                keyValue: 5,
                column: "category_name",
                value: "SmartWatch");

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 1,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 2,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 3,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 4,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 5,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 6,
                columns: new[] { "created_date", "effective_date" },
                values: new object[] { new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
