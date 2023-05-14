﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using HusinKonak.Data;

#nullable disable

namespace HusinKonak.Migrations
{
    [DbContext(typeof(RestaurantDBContext))]
    [Migration("20230513120438_RestaurantDB")]
    partial class RestaurantDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerOrder", b =>
                {
                    b.Property<int>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrdersOrderId")
                        .HasColumnType("int");

                    b.HasKey("CustomersCustomerId", "OrdersOrderId");

                    b.HasIndex("OrdersOrderId");

                    b.ToTable("CustomerOrder");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLoyaltyMember")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.CustomerReward", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("RewardId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "RewardId");

                    b.HasIndex("RewardId");

                    b.ToTable("CustomerReward");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Delivery", b =>
                {
                    b.Property<int>("DeliveryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeliveryId"));

                    b.Property<string>("DeliveryAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("DeliveryTime")
                        .HasColumnType("time");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("DeliveryId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiscountId");

                    b.HasIndex("OrderID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.DiscountMenuItem", b =>
                {
                    b.Property<int>("DiscountID")
                        .HasColumnType("int");

                    b.Property<int>("MenuItemID")
                        .HasColumnType("int");

                    b.HasKey("DiscountID", "MenuItemID");

                    b.HasIndex("MenuItemID");

                    b.ToTable("DiscountMenuItem");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("AdminId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.EmployeeEvent", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("EmployeeEvent");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuItemId"));

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SpecialInstructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuItemId");

                    b.HasIndex("InventoryId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("TableId")
                        .IsUnique();

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.OrderItemMenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderItemId")
                        .HasColumnType("int");

                    b.HasKey("MenuItemId", "OrderItemId");

                    b.HasIndex("OrderItemId");

                    b.ToTable("OrderItemMenuItem");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.OrderItemReview", b =>
                {
                    b.Property<int>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.Property<int>("OrderItemReviewId")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId", "ReviewId");

                    b.HasIndex("ReviewId");

                    b.ToTable("OrderItemReview");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId");

                    b.HasIndex("TransactionId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewId");

                    b.HasIndex("CustomerID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Reward", b =>
                {
                    b.Property<int>("RewardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RewardId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasKey("RewardId");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.TableReservation", b =>
                {
                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("TableId", "ReservationId");

                    b.HasIndex("ReservationId");

                    b.ToTable("TableReservation");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CustomerOrder", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Classes_for_Restaurant.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.CustomerReward", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Customer", "Customer")
                        .WithMany("CustomerRewards")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Classes_for_Restaurant.Reward", "Reward")
                        .WithMany("CustomerRewards")
                        .HasForeignKey("RewardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Reward");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Discount", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.DiscountMenuItem", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Discount", "Discount")
                        .WithMany("DiscountMenuItems")
                        .HasForeignKey("DiscountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Classes_for_Restaurant.MenuItem", "MenuItem")
                        .WithMany("DiscountMenuItems")
                        .HasForeignKey("MenuItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discount");

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Employee", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Admin", "Admin")
                        .WithMany("Employees")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.EmployeeEvent", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Employee", "Employee")
                        .WithMany("EmployeeEvents")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Classes_for_Restaurant.Event", "Event")
                        .WithMany("EmployeeEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.MenuItem", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Inventory", "Inventory")
                        .WithMany("MenuItems")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Order", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Delivery", "Delivery")
                        .WithOne("Order")
                        .HasForeignKey("HusinKonak.Classes_for_Restaurant.Order", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Classes_for_Restaurant.Table", "Table")
                        .WithOne("Order")
                        .HasForeignKey("HusinKonak.Classes_for_Restaurant.Order", "TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Delivery");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.OrderItem", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.OrderItemMenuItem", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.MenuItem", "MenuItem")
                        .WithMany("OrderItemMenuItems")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Classes_for_Restaurant.OrderItem", "OrderItem")
                        .WithMany("OrderItemMenuItems")
                        .HasForeignKey("OrderItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.OrderItemReview", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.OrderItem", "OrderItem")
                        .WithMany("OrderItemReviews")
                        .HasForeignKey("OrderItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Classes_for_Restaurant.Review", "Review")
                        .WithMany("OrderItemReviews")
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderItem");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Payment", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Classes_for_Restaurant.Transaction", "Transaction")
                        .WithMany("Payments")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Reservation", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Review", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Reward", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.TableReservation", b =>
                {
                    b.HasOne("HusinKonak.Classes_for_Restaurant.Reservation", "Reservation")
                        .WithMany("TableReservations")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HusinKonak.Classes_for_Restaurant.Table", "Table")
                        .WithMany("TableReservations")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Admin", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Customer", b =>
                {
                    b.Navigation("CustomerRewards");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Delivery", b =>
                {
                    b.Navigation("Order")
                        .IsRequired();
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Discount", b =>
                {
                    b.Navigation("DiscountMenuItems");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Employee", b =>
                {
                    b.Navigation("EmployeeEvents");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Event", b =>
                {
                    b.Navigation("EmployeeEvents");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Inventory", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.MenuItem", b =>
                {
                    b.Navigation("DiscountMenuItems");

                    b.Navigation("OrderItemMenuItems");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Order", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.OrderItem", b =>
                {
                    b.Navigation("OrderItemMenuItems");

                    b.Navigation("OrderItemReviews");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Reservation", b =>
                {
                    b.Navigation("TableReservations");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Review", b =>
                {
                    b.Navigation("OrderItemReviews");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Reward", b =>
                {
                    b.Navigation("CustomerRewards");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Table", b =>
                {
                    b.Navigation("Order")
                        .IsRequired();

                    b.Navigation("TableReservations");
                });

            modelBuilder.Entity("HusinKonak.Classes_for_Restaurant.Transaction", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
