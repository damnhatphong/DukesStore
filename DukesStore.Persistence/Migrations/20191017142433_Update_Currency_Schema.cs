using Microsoft.EntityFrameworkCore.Migrations;

namespace DukesStore.Persistence.Migrations
{
    public partial class Update_Currency_Schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prices_Currencies_CurrencyId",
                schema: "production",
                table: "prices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Currency",
                newSchema: "production");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currency",
                schema: "production",
                table: "Currency",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_prices_Currency_CurrencyId",
                schema: "production",
                table: "prices",
                column: "CurrencyId",
                principalSchema: "production",
                principalTable: "Currency",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prices_Currency_CurrencyId",
                schema: "production",
                table: "prices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currency",
                schema: "production",
                table: "Currency");

            migrationBuilder.RenameTable(
                name: "Currency",
                schema: "production",
                newName: "Currencies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_prices_Currencies_CurrencyId",
                schema: "production",
                table: "prices",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
