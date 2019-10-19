using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DukesStore.Persistence.Migrations
{
    public partial class Initial_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "production");

            migrationBuilder.EnsureSchema(
                name: "sales");

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrencyUnit = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "brands",
                schema: "production",
                columns: table => new
                {
                    brand_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brand_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__brands__5E5A8E27D7920438", x => x.brand_id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                schema: "production",
                columns: table => new
                {
                    category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__categori__D54EE9B467C10685", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                schema: "sales",
                columns: table => new
                {
                    customer_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    phone = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    street = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ward = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    district = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    zip_code = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__customer__CD65CB857BC22627", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                schema: "sales",
                columns: table => new
                {
                    store_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    store_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    phone = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    street = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ward = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    district = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    zip_code = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__stores__A2F2A30C53407733", x => x.store_id);
                });

            migrationBuilder.CreateTable(
                name: "prices",
                schema: "production",
                columns: table => new
                {
                    price_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    created_date = table.Column<DateTime>(nullable: false),
                    effective_date = table.Column<DateTime>(nullable: false),
                    amount = table.Column<decimal>(type: "smallmoney", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    CurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__prices__1681726D53E1AE73", x => x.price_id);
                    table.ForeignKey(
                        name: "FK_prices_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "CurrencyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "staffs",
                schema: "sales",
                columns: table => new
                {
                    staff_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    phone = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    active = table.Column<byte>(nullable: false),
                    store_id = table.Column<int>(nullable: false),
                    manager_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__staffs__1963DD9C6436288A", x => x.staff_id);
                    table.ForeignKey(
                        name: "FK__staffs__manager___49C3F6B7",
                        column: x => x.manager_id,
                        principalSchema: "sales",
                        principalTable: "staffs",
                        principalColumn: "staff_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__staffs__store_id__48CFD27E",
                        column: x => x.store_id,
                        principalSchema: "sales",
                        principalTable: "stores",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                schema: "production",
                columns: table => new
                {
                    product_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    product_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    brand_id = table.Column<int>(nullable: false),
                    category_id = table.Column<int>(nullable: false),
                    model_year = table.Column<short>(nullable: false),
                    price_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__products__47027DF565E8B779", x => x.product_id);
                    table.ForeignKey(
                        name: "FK__products__brand___412EB0B6",
                        column: x => x.brand_id,
                        principalSchema: "production",
                        principalTable: "brands",
                        principalColumn: "brand_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__products__price___403A8C7D",
                        column: x => x.category_id,
                        principalSchema: "production",
                        principalTable: "categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__products__price___4222D4EF",
                        column: x => x.price_id,
                        principalSchema: "production",
                        principalTable: "prices",
                        principalColumn: "price_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                schema: "sales",
                columns: table => new
                {
                    order_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<int>(nullable: true),
                    order_status = table.Column<byte>(nullable: false),
                    order_date = table.Column<DateTime>(type: "date", nullable: false),
                    required_date = table.Column<DateTime>(type: "date", nullable: false),
                    shipped_date = table.Column<DateTime>(type: "date", nullable: true),
                    store_id = table.Column<int>(nullable: false),
                    staff_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__orders__46596229E1A61EA0", x => x.order_id);
                    table.ForeignKey(
                        name: "FK__orders__customer__4CA06362",
                        column: x => x.customer_id,
                        principalSchema: "sales",
                        principalTable: "customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__orders__staff_id__4E88ABD4",
                        column: x => x.staff_id,
                        principalSchema: "sales",
                        principalTable: "staffs",
                        principalColumn: "staff_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__orders__store_id__4D94879B",
                        column: x => x.store_id,
                        principalSchema: "sales",
                        principalTable: "stores",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stocks",
                schema: "production",
                columns: table => new
                {
                    store_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__stocks__E68284D364CBE4C9", x => new { x.store_id, x.product_id });
                    table.ForeignKey(
                        name: "FK__stocks__product___571DF1D5",
                        column: x => x.product_id,
                        principalSchema: "production",
                        principalTable: "products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__stocks__store_id__5629CD9C",
                        column: x => x.store_id,
                        principalSchema: "sales",
                        principalTable: "stores",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_items",
                schema: "sales",
                columns: table => new
                {
                    order_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    total_price = table.Column<decimal>(type: "smallmoney", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(4, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__order_it__022945F6D924F325", x => new { x.order_id, x.product_id });
                    table.ForeignKey(
                        name: "FK__order_ite__order__52593CB8",
                        column: x => x.order_id,
                        principalSchema: "sales",
                        principalTable: "orders",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__order_ite__produ__534D60F1",
                        column: x => x.product_id,
                        principalSchema: "production",
                        principalTable: "products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_prices_CurrencyId",
                schema: "production",
                table: "prices",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_products_brand_id",
                schema: "production",
                table: "products",
                column: "brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_category_id",
                schema: "production",
                table: "products",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_products_price_id",
                schema: "production",
                table: "products",
                column: "price_id");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_product_id",
                schema: "production",
                table: "stocks",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "UQ__customer__AB6E6164AF8A0B90",
                schema: "sales",
                table: "customers",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_order_items_product_id",
                schema: "sales",
                table: "order_items",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_customer_id",
                schema: "sales",
                table: "orders",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_staff_id",
                schema: "sales",
                table: "orders",
                column: "staff_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_store_id",
                schema: "sales",
                table: "orders",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "UQ__staffs__AB6E616469570119",
                schema: "sales",
                table: "staffs",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_staffs_manager_id",
                schema: "sales",
                table: "staffs",
                column: "manager_id");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_store_id",
                schema: "sales",
                table: "staffs",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "UQ__stores__AB6E61648E182554",
                schema: "sales",
                table: "stores",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stocks",
                schema: "production");

            migrationBuilder.DropTable(
                name: "order_items",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "orders",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "products",
                schema: "production");

            migrationBuilder.DropTable(
                name: "customers",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "staffs",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "brands",
                schema: "production");

            migrationBuilder.DropTable(
                name: "categories",
                schema: "production");

            migrationBuilder.DropTable(
                name: "prices",
                schema: "production");

            migrationBuilder.DropTable(
                name: "stores",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
