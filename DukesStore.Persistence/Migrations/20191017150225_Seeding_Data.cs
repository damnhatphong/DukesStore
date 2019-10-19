using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DukesStore.Persistence.Migrations
{
    public partial class Seeding_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "production",
                table: "Currency",
                columns: new[] { "CurrencyId", "CreatedDate", "CurrencyUnit" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "USD" },
                    { 12, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "VND" }
                });

            migrationBuilder.InsertData(
                schema: "production",
                table: "brands",
                columns: new[] { "brand_id", "brand_name" },
                values: new object[,]
                {
                    { 1, "Apple" },
                    { 2, "SamSung" },
                    { 3, "Sony" },
                    { 4, "Huawei" },
                    { 5, "Xiaomi" },
                    { 6, "Microsoft" }
                });

            migrationBuilder.InsertData(
                schema: "production",
                table: "categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[,]
                {
                    { 1, "Phone" },
                    { 2, "Tablet" },
                    { 3, "Laptop" },
                    { 4, "HeadPhone" },
                    { 5, "SmartWatch" }
                });

            migrationBuilder.InsertData(
                schema: "production",
                table: "prices",
                columns: new[] { "price_id", "amount", "created_date", "CurrencyId", "description", "effective_date" },
                values: new object[,]
                {
                    { 1, 999.9m, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, "Discription", new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 699.9m, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, "Discription", new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 599.9m, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, "Discription", new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 1499.9m, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, "Discription", new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 5, 2599.9m, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, "Discription", new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 6, 399.9m, new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, "Discription", new DateTime(2019, 10, 17, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                schema: "production",
                table: "products",
                columns: new[] { "product_id", "brand_id", "category_id", "model_year", "price_id", "product_name" },
                values: new object[] { 1, 1, 1, (short)2019, 1, "IPhone 11 Pro" });

            migrationBuilder.InsertData(
                schema: "production",
                table: "products",
                columns: new[] { "product_id", "brand_id", "category_id", "model_year", "price_id", "product_name" },
                values: new object[] { 2, 2, 1, (short)2019, 1, "Galaxy Note10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "categories",
                keyColumn: "category_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "categories",
                keyColumn: "category_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "categories",
                keyColumn: "category_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "categories",
                keyColumn: "category_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "products",
                keyColumn: "product_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "products",
                keyColumn: "product_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "categories",
                keyColumn: "category_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "prices",
                keyColumn: "price_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "production",
                table: "Currency",
                keyColumn: "CurrencyId",
                keyValue: 1);
        }
    }
}
