using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace userInterface.Entities
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

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StoreLocation> StoreLocations { get; set; }
        public virtual DbSet<StoreOrder> StoreOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserAddress)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("user_address");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_email");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPhone).HasColumnName("User_phone");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.ToTable("LineItem");

                entity.Property(e => e.LineItemId).HasColumnName("lineItem_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.QuantityNumber)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("quantity_number");

                entity.Property(e => e.StoreOrderId).HasColumnName("store_order_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineItem__produc__2A164134");

                entity.HasOne(d => d.StoreOrder)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.StoreOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LineItem__store___29221CFB");
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

            modelBuilder.Entity<StoreLocation>(entity =>
            {
                entity.ToTable("StoreLocation");

                entity.Property(e => e.StoreLocationId).HasColumnName("store_id");

                entity.Property(e => e.StoreLocationAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_address");

                entity.Property(e => e.StoreLocationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_name");

                entity.Property(e => e.StoreLocationPhone).HasColumnName("store_phone");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.ToTable("StoreOrder");

                entity.Property(e => e.StoreOrderId).HasColumnName("store_order_id");

                entity.Property(e => e.UsersId).HasColumnName("users_id");

                entity.Property(e => e.StoreLocationId).HasColumnName("storeLocation_id");

                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("total_price");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.StoreOrders)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StoreOrde__custo__2645B050");

                entity.HasOne(d => d.StoreLocation)
                    .WithMany(p => p.StoreOrders)
                    .HasForeignKey(d => d.StoreLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StoreOrde__store__25518C17");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
