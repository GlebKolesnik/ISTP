using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BD2._0;

public partial class OnlineShopContext : DbContext
{
    public OnlineShopContext()
    {
    }

    public OnlineShopContext(DbContextOptions<OnlineShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accessory> Accessories { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Clothe> Clothes { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Shoe> Shoes { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    public virtual DbSet<_11> _11s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= DESKTOP-LN7QPED\\SQLEXPRESS01;Database=Online-Shop;Trusted_Connection=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accessory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ACCESSORIES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BRAND");

            entity.ToTable("Brand");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Brand1).HasColumnName("Brand");
        });

        modelBuilder.Entity<Clothe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CLOTHES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");

            entity.HasOne(d => d.BrandNavigation).WithMany(p => p.Clothes)
                .HasForeignKey(d => d.Brand)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Clothes_fk3");

            entity.HasOne(d => d.ColorNavigation).WithMany(p => p.Clothes)
                .HasForeignKey(d => d.Color)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Clothes_fk0");

            entity.HasOne(d => d.SizeNavigation).WithMany(p => p.Clothes)
                .HasForeignKey(d => d.Size)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Clothes_fk2");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Clothes)
                .HasForeignKey(d => d.Type)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Clothes_fk1");
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_COLOR");

            entity.ToTable("Color");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Color1).HasColumnName("Color");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PRODUCTS");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");

            entity.HasOne(d => d.AccessoriesNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Accessories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Products_fk2");

            entity.HasOne(d => d.ClothesNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Clothes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Products_fk0");

            entity.HasOne(d => d.ShoesNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Shoes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Products_fk1");
        });

        modelBuilder.Entity<Shoe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SHOES");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SIZE");

            entity.ToTable("Size");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Size1).HasColumnName("Size");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TYPE");

            entity.ToTable("Type");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Type1).HasColumnName("Type");
        });

        modelBuilder.Entity<_11>(entity =>
        {
            entity.ToTable("1.1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Hut).HasColumnName("HUT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
