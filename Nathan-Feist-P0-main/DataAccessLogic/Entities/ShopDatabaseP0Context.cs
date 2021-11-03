using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccessLogic.Entities
{
    public partial class ShopDatabaseP0Context : DbContext
    {
        public ShopDatabaseP0Context()
        {
        }

        public ShopDatabaseP0Context(DbContextOptions<ShopDatabaseP0Context> options)
            : base(options)
        {
        }

        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<LineItemOrder> LineItemOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StoreLocation> StoreLocations { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.Property(e => e.QuantityNumber).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__LineItems__Produ__2EDAF651");
            });

            modelBuilder.Entity<LineItemOrder>(entity =>
            {
                entity.ToTable("LineItemOrder");

                entity.Property(e => e.LineItemLineItemId).HasColumnName("LineItem_LineItemId");

                entity.HasOne(d => d.LineItemLineItem)
                    .WithMany(p => p.LineItemOrders)
                    .HasForeignKey(d => d.LineItemLineItemId)
                    .HasConstraintName("foreign_key_LineItemOrder");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.LineItem)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.LineItemId)
                    .HasConstraintName("FK__Orders__LineItem__3A4CA8FD");

                entity.HasOne(d => d.StoreAddressNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreAddress)
                    .HasConstraintName("FK__Orders__StoreAdd__3C34F16F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__UserId__3B40CD36");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<StoreLocation>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__StoreLoc__3B82F1016C2791F0");

                entity.ToTable("StoreLocation");

                entity.Property(e => e.StoreAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
