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

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StoreAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
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
