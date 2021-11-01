using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class PODatabase1Context : DbContext
    {
        public PODatabase1Context()
        {
        }

        public PODatabase1Context(DbContextOptions<PODatabase1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<LineItemOrder> LineItemOrders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }
        public virtual DbSet<StoreOrder> StoreOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("customer_address");

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_email");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("customer_phone");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.ToTable("LineItem");

                entity.Property(e => e.LineItemId).HasColumnName("lineItem_id");

                entity.Property(e => e.OrderStoreFrontAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_storeFront_address");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.QuantityNumber)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("quantity_number");

                entity.Property(e => e.StoreOrderId).HasColumnName("store_order_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineItem__produc__4A8310C6");

                entity.HasOne(d => d.StoreOrder)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.StoreOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineItem__store___498EEC8D");
            });

            modelBuilder.Entity<LineItemOrder>(entity =>
            {
                entity.ToTable("LineItem_Order");

                entity.Property(e => e.LineitemOrderId).HasColumnName("lineitem_order_id");

                entity.Property(e => e.LineItemId).HasColumnName("lineItem_id");

                entity.Property(e => e.StoreOrderId).HasColumnName("store_order_id");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.LineItemOrders)
                    .HasForeignKey(d => d.LineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineItem___lineI__4E53A1AA");

                entity.HasOne(d => d.StoreOrder)
                    .WithMany(p => p.LineItemOrders)
                    .HasForeignKey(d => d.StoreOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineItem___store__4D5F7D71");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_category");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_description");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductPrice)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("product_price");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.ToTable("StoreFront");

                entity.Property(e => e.StoreFrontId).HasColumnName("storeFront_id");

                entity.Property(e => e.StoreFrontAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storeFront_address");

                entity.Property(e => e.StoreFrontName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storeFront_name");

                entity.Property(e => e.StoreFrontPhone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("storeFront_phone");
            });

            modelBuilder.Entity<StoreOrder>(entity =>
            {
                entity.ToTable("StoreOrder");

                entity.Property(e => e.StoreOrderId).HasColumnName("store_order_id");

                entity.Property(e => e.CustomersId).HasColumnName("customers_id");

                entity.Property(e => e.StoreFrontAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("storeFront_address");

                entity.Property(e => e.StoreFrontId).HasColumnName("storeFront_id");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("total_price");

                entity.HasOne(d => d.Customers)
                    .WithMany(p => p.StoreOrders)
                    .HasForeignKey(d => d.CustomersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StoreOrde__custo__46B27FE2");

                entity.HasOne(d => d.StoreFront)
                    .WithMany(p => p.StoreOrders)
                    .HasForeignKey(d => d.StoreFrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StoreOrde__store__45BE5BA9");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
