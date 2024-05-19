using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObjects.Models;

public partial class JssatsContext : DbContext
{
    public JssatsContext()
    {
    }

    public JssatsContext(DbContextOptions<JssatsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillJewelry> BillJewelries { get; set; }

    public virtual DbSet<BillPromotion> BillPromotions { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<GoldPrice> GoldPrices { get; set; }

    public virtual DbSet<Jewelry> Jewelries { get; set; }

    public virtual DbSet<JewelryType> JewelryTypes { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Warranty> Warranties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
    }
    private string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        //return config["ConnectionStrings:DBConnect"];
        var strConn = config["ConnectionStrings:StockDB"];
        return strConn ?? "";
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.BillId).HasName("PK__Bill__11F2FC6AF4D744A5");

            entity.ToTable("Bill");

            entity.Property(e => e.BillId).ValueGeneratedNever();
            entity.Property(e => e.SaleDate).HasColumnType("datetime");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bills)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Bill__CustomerId__59063A47");

            entity.HasOne(d => d.User).WithMany(p => p.Bills)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Bill__UserId__59FA5E80");
        });

        modelBuilder.Entity<BillJewelry>(entity =>
        {
            entity.HasKey(e => e.BillJewelryId).HasName("PK__BillJewe__22A11463AC25A531");

            entity.ToTable("BillJewelry");

            entity.Property(e => e.BillJewelryId).ValueGeneratedNever();

            entity.HasOne(d => d.Bill).WithMany(p => p.BillJewelries)
                .HasForeignKey(d => d.BillId)
                .HasConstraintName("FK__BillJewel__BillI__534D60F1");

            entity.HasOne(d => d.Jewelry).WithMany(p => p.BillJewelries)
                .HasForeignKey(d => d.JewelryId)
                .HasConstraintName("FK__BillJewel__Jewel__52593CB8");
        });

        modelBuilder.Entity<BillPromotion>(entity =>
        {
            entity.HasKey(e => e.BillPromotionId).HasName("PK__BillProm__470D21BE64B2BD0E");

            entity.ToTable("BillPromotion");

            entity.Property(e => e.BillPromotionId).ValueGeneratedNever();

            entity.HasOne(d => d.Bill).WithMany(p => p.BillPromotions)
                .HasForeignKey(d => d.BillId)
                .HasConstraintName("FK__BillPromo__BillI__5165187F");

            entity.HasOne(d => d.Promotion).WithMany(p => p.BillPromotions)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("FK__BillPromo__Promo__5070F446");
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasKey(e => e.CounterId).HasName("PK__Counter__F12879C46062171F");

            entity.ToTable("Counter");

            entity.Property(e => e.CounterId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D838926A2D");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<GoldPrice>(entity =>
        {
            entity.HasKey(e => e.GoldPriceId).HasName("PK__GoldPric__C2C7860C15E71B5C");

            entity.ToTable("GoldPrice");

            entity.Property(e => e.GoldPriceId).ValueGeneratedNever();
            entity.Property(e => e.Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<Jewelry>(entity =>
        {
            entity.HasKey(e => e.JewelryId).HasName("PK__Jewelry__807031D54B2A1A19");

            entity.ToTable("Jewelry");

            entity.Property(e => e.JewelryId).ValueGeneratedNever();
            entity.Property(e => e.Barcode).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.JewelryType).WithMany(p => p.Jewelries)
                .HasForeignKey(d => d.JewelryTypeId)
                .HasConstraintName("FK__Jewelry__Jewelry__4F7CD00D");

            entity.HasOne(d => d.Warranty).WithMany(p => p.Jewelries)
                .HasForeignKey(d => d.WarrantyId)
                .HasConstraintName("FK__Jewelry__Warrant__4E88ABD4");
        });

        modelBuilder.Entity<JewelryType>(entity =>
        {
            entity.HasKey(e => e.JewelryTypeId).HasName("PK__JewelryT__7DCE241605B413D9");

            entity.ToTable("JewelryType");

            entity.Property(e => e.JewelryTypeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.PromotionId).HasName("PK__Promotio__52C42FCF370ED400");

            entity.ToTable("Promotion");

            entity.Property(e => e.PromotionId).ValueGeneratedNever();
            entity.Property(e => e.ApproveManager).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PK__Purchase__6B0A6BBE4F22BFE3");

            entity.ToTable("Purchase");

            entity.Property(e => e.PurchaseId).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Purchase__Custom__5629CD9C");

            entity.HasOne(d => d.Jewelry).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.JewelryId)
                .HasConstraintName("FK__Purchase__Jewelr__5441852A");

            entity.HasOne(d => d.User).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Purchase__UserId__5535A963");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__8AFACE1AB86F2F76");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
            entity.Property(e => e.RoleName).HasMaxLength(255);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4C80E6E43E");

            entity.ToTable("User");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(255);

            entity.HasOne(d => d.Counter).WithMany(p => p.Users)
                .HasForeignKey(d => d.CounterId)
                .HasConstraintName("FK__User__CounterId__5812160E");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__User__RoleId__571DF1D5");
        });

        modelBuilder.Entity<Warranty>(entity =>
        {
            entity.HasKey(e => e.WarrantyId).HasName("PK__Warranty__2ED318137422BCE7");

            entity.ToTable("Warranty");

            entity.Property(e => e.WarrantyId).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
