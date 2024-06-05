using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObjects.Context
{
    public class JssatsContext : DbContext
    {
        public JssatsContext()
        {
        }

        public JssatsContext(DbContextOptions<JssatsContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private static string GetConnectionString()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var strConn = config["ConnectionStrings:JSSATS"];
            return strConn;
        }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillJewelry> BillJewelries { get; set; }
        public DbSet<BillPromotion> BillPromotions { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Jewelry> Jewelries { get; set; }
        public DbSet<JewelryType> JewelryTypes { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<MasterPrice> MasterPrices { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<JewelryMaterial> JewelryMaterials { get; set; }
        public DbSet<GoldPrice> GoldPrices { get; set; }
        public DbSet<StonePrice> StonePrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bill>()
                .HasKey(b => b.BillId);

            modelBuilder.Entity<Bill>()
                .Property(b => b.BillId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<BillJewelry>()
                .HasKey(bj => bj.BillJewelryId);

            modelBuilder.Entity<BillJewelry>()
                .Property(bj => bj.BillJewelryId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<BillPromotion>()
                .HasKey(bp => bp.BillPromotionId);

            modelBuilder.Entity<BillPromotion>()
                .Property(bp => bp.BillPromotionId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Counter>()
                .HasKey(c => c.CounterId);

            modelBuilder.Entity<Counter>()
                .Property(c => c.CounterId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Customer>()
                .HasKey(cu => cu.CustomerId);

            modelBuilder.Entity<Customer>()
                .Property(cu => cu.CustomerId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<GoldPrice>()
                .HasKey(gp => gp.GoldPriceId);

            modelBuilder.Entity<GoldPrice>()
                .Property(gp => gp.GoldPriceId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Jewelry>()
                .HasKey(j => j.JewelryId);

            modelBuilder.Entity<Jewelry>()
                .Property(j => j.JewelryId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<JewelryType>()
                .HasKey(jt => jt.JewelryTypeId);

            modelBuilder.Entity<JewelryType>()
                .Property(jt => jt.JewelryTypeId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Promotion>()
                .HasKey(p => p.PromotionId);

            modelBuilder.Entity<Promotion>()
                .Property(p => p.PromotionId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Purchase>()
                .HasKey(p => p.PurchaseId);

            modelBuilder.Entity<Purchase>()
                .Property(p => p.PurchaseId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Role>()
                .HasKey(r => r.RoleId);

            modelBuilder.Entity<Role>()
                .Property(r => r.RoleId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<User>()
                .Property(u => u.UserId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            modelBuilder.Entity<Warranty>()
                .HasKey(w => w.WarrantyId);

            modelBuilder.Entity<Warranty>()
                .Property(w => w.WarrantyId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            modelBuilder.Entity<MasterPrice>()
                .HasKey(mp => mp.MasterPriceId);
            
            modelBuilder.Entity<MasterPrice>()
                .Property(mp => mp.MasterPriceId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            modelBuilder.Entity<Material>()
                .HasKey(m => m.MaterialId);
            
            modelBuilder.Entity<Material>()
                .Property(m => m.MaterialId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            
            modelBuilder.Entity<StonePrice>()
                .HasKey(sp => sp.StonePriceId);
            
            modelBuilder.Entity<StonePrice>()
                .Property(sp => sp.StonePriceId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            // Relationships
            modelBuilder.Entity<MasterPrice>()
                .HasOne(mp => mp.GoldPrice)
                .WithMany(gp => gp.MasterPrices)
                .HasForeignKey(mp => mp.GoldPriceId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<MasterPrice>()
                .HasOne(mp => mp.StonePrice)
                .WithMany(sp => sp.MasterPrices)
                .HasForeignKey(mp => mp.StonePriceId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<JewelryMaterial>()
                .HasOne(jm => jm.Jewelry)
                .WithMany(j=> j.JewelryMaterials)
                .HasForeignKey(jm => jm.JewelryId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<JewelryMaterial>()
                .HasOne(jm => jm.Material)
                .WithMany(m => m.JewelryMaterials)
                .HasForeignKey(jm => jm.MaterialId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<JewelryMaterial>()
                .HasOne(jm => jm.MasterPrice)
                .WithMany(mp => mp.JewelryMaterials)
                .HasForeignKey(jm => jm.MasterPriceId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Warranty>()
                .HasOne(w => w.Jewelry)
                .WithOne(j => j.Warranty)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Bill>()
                .HasOne(b => b.Customer)
                .WithMany(cu => cu.Bills)
                .HasForeignKey(b => b.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Bill>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bills)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BillJewelry>()
                .HasOne(bj => bj.Bill)
                .WithMany(b => b.BillJewelries)
                .HasForeignKey(bj => bj.BillId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BillJewelry>()
                .HasOne(bj => bj.Jewelry)
                .WithMany(j => j.BillJewelries)
                .HasForeignKey(bj => bj.JewelryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BillPromotion>()
                .HasOne(bp => bp.Bill)
                .WithMany(b => b.BillPromotions)
                .HasForeignKey(bp => bp.BillId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BillPromotion>()
                .HasOne(bp => bp.Promotion)
                .WithMany(p => p.BillPromotions)
                .HasForeignKey(bp => bp.PromotionId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Jewelry>()
                .HasOne(j => j.JewelryType)
                .WithMany(jt => jt.Jewelries)
                .HasForeignKey(j => j.JewelryTypeId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Customer)
                .WithMany(cu => cu.Purchases)
                .HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Jewelry)
                .WithMany(j => j.Purchases)
                .HasForeignKey(p => p.JewelryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.User)
                .WithMany(u => u.Purchases)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Counter)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.CounterId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
