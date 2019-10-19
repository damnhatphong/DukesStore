﻿// <auto-generated />
using System;
using DukesStore.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DukesStore.Persistence.Migrations
{
    [DbContext(typeof(DukesEShopContext))]
    [Migration("20191017142433_Update_Currency_Schema")]
    partial class Update_Currency_Schema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Brands", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("brand_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnName("brand_name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("BrandId")
                        .HasName("PK__brands__5E5A8E27D7920438");

                    b.ToTable("brands","production");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("category_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnName("category_name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("CategoryId")
                        .HasName("PK__categori__D54EE9B467C10685");

                    b.ToTable("categories","production");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("CurrencyUnit");

                    b.HasKey("CurrencyId");

                    b.ToTable("Currency","production");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("District")
                        .HasColumnName("district")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Street")
                        .HasColumnName("street")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Ward")
                        .HasColumnName("ward")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("ZipCode")
                        .HasColumnName("zip_code")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.HasKey("CustomerId")
                        .HasName("PK__customer__CD65CB857BC22627");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasName("UQ__customer__AB6E6164AF8A0B90");

                    b.ToTable("customers","sales");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.OrderItems", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("order_id");

                    b.Property<int>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<decimal>("Discount")
                        .HasColumnName("discount")
                        .HasColumnType("decimal(4, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnName("quantity");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnName("total_price")
                        .HasColumnType("smallmoney");

                    b.HasKey("OrderId", "ProductId")
                        .HasName("PK__order_it__022945F6D924F325");

                    b.HasIndex("ProductId");

                    b.ToTable("order_items","sales");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("order_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnName("order_date")
                        .HasColumnType("date");

                    b.Property<byte>("OrderStatus")
                        .HasColumnName("order_status");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnName("required_date")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnName("shipped_date")
                        .HasColumnType("date");

                    b.Property<int>("StaffId")
                        .HasColumnName("staff_id");

                    b.Property<int>("StoreId")
                        .HasColumnName("store_id");

                    b.HasKey("OrderId")
                        .HasName("PK__orders__46596229E1A61EA0");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StaffId");

                    b.HasIndex("StoreId");

                    b.ToTable("orders","sales");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Prices", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("price_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnName("amount")
                        .HasColumnType("smallmoney");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnName("created_date");

                    b.Property<int>("CurrencyId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnName("effective_date");

                    b.HasKey("PriceId")
                        .HasName("PK__prices__1681726D53E1AE73");

                    b.HasIndex("CurrencyId");

                    b.ToTable("prices","production");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("product_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnName("brand_id");

                    b.Property<int>("CategoryId")
                        .HasColumnName("category_id");

                    b.Property<short>("ModelYear")
                        .HasColumnName("model_year");

                    b.Property<int>("PriceId")
                        .HasColumnName("price_id");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnName("product_name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.HasKey("ProductId")
                        .HasName("PK__products__47027DF565E8B779");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PriceId");

                    b.ToTable("products","production");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Staffs", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("staff_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Active")
                        .HasColumnName("active");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("ManagerId")
                        .HasColumnName("manager_id");

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<int>("StoreId")
                        .HasColumnName("store_id");

                    b.HasKey("StaffId")
                        .HasName("PK__staffs__1963DD9C6436288A");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasName("UQ__staffs__AB6E616469570119");

                    b.HasIndex("ManagerId");

                    b.HasIndex("StoreId");

                    b.ToTable("staffs","sales");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Stocks", b =>
                {
                    b.Property<int>("StoreId")
                        .HasColumnName("store_id");

                    b.Property<int>("ProductId")
                        .HasColumnName("product_id");

                    b.Property<int?>("Quantity")
                        .HasColumnName("quantity");

                    b.HasKey("StoreId", "ProductId")
                        .HasName("PK__stocks__E68284D364CBE4C9");

                    b.HasIndex("ProductId");

                    b.ToTable("stocks","production");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Stores", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("store_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnName("city")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("District")
                        .HasColumnName("district")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnName("store_name")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Street")
                        .HasColumnName("street")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("Ward")
                        .HasColumnName("ward")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<string>("ZipCode")
                        .HasColumnName("zip_code")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.HasKey("StoreId")
                        .HasName("PK__stores__A2F2A30C53407733");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasName("UQ__stores__AB6E61648E182554")
                        .HasFilter("[email] IS NOT NULL");

                    b.ToTable("stores","sales");
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.OrderItems", b =>
                {
                    b.HasOne("DukesStore.ApplicationCore.Entities.Orders", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__order_ite__order__52593CB8")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DukesStore.ApplicationCore.Entities.Products", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__order_ite__produ__534D60F1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Orders", b =>
                {
                    b.HasOne("DukesStore.ApplicationCore.Entities.Customers", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__orders__customer__4CA06362")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DukesStore.ApplicationCore.Entities.Staffs", "Staff")
                        .WithMany("Orders")
                        .HasForeignKey("StaffId")
                        .HasConstraintName("FK__orders__staff_id__4E88ABD4");

                    b.HasOne("DukesStore.ApplicationCore.Entities.Stores", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreId")
                        .HasConstraintName("FK__orders__store_id__4D94879B")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Prices", b =>
                {
                    b.HasOne("DukesStore.ApplicationCore.Entities.Currency", "Currency")
                        .WithMany("Prices")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Products", b =>
                {
                    b.HasOne("DukesStore.ApplicationCore.Entities.Brands", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .HasConstraintName("FK__products__brand___412EB0B6")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DukesStore.ApplicationCore.Entities.Categories", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__products__price___403A8C7D")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DukesStore.ApplicationCore.Entities.Prices", "Price")
                        .WithMany("Products")
                        .HasForeignKey("PriceId")
                        .HasConstraintName("FK__products__price___4222D4EF")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Staffs", b =>
                {
                    b.HasOne("DukesStore.ApplicationCore.Entities.Staffs", "Manager")
                        .WithMany("InverseManager")
                        .HasForeignKey("ManagerId")
                        .HasConstraintName("FK__staffs__manager___49C3F6B7");

                    b.HasOne("DukesStore.ApplicationCore.Entities.Stores", "Store")
                        .WithMany("Staffs")
                        .HasForeignKey("StoreId")
                        .HasConstraintName("FK__staffs__store_id__48CFD27E")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DukesStore.ApplicationCore.Entities.Stocks", b =>
                {
                    b.HasOne("DukesStore.ApplicationCore.Entities.Products", "Product")
                        .WithMany("Stocks")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__stocks__product___571DF1D5")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DukesStore.ApplicationCore.Entities.Stores", "Store")
                        .WithMany("Stocks")
                        .HasForeignKey("StoreId")
                        .HasConstraintName("FK__stocks__store_id__5629CD9C")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
