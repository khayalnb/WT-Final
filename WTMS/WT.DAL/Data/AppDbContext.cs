using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WT.DAL.Models;

namespace WT.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<AdressType> AdressTypes { get; set; }
        public DbSet<AppSetting> AppSettings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CorporativeSale> CorporativeSales { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<OfferCompany> OfferCompanies { get; set; }
        public DbSet<OrderComplate> OrderComplates { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductParametr> ProductParametrs { get; set; }
        public DbSet<ShopAndOffice> ShopAndOffices { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
              .HasMany(c => c.SubCategories)
              .WithOne(e => e.Category)
              .HasForeignKey(s=>s.CategoryId)
              .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Category>()
               .HasIndex(c => c.Name)
               .IsUnique();

            modelBuilder.Entity<SubCategory>()
              .HasIndex(c => c.Name)
              .IsUnique();

            modelBuilder.HasDefaultSchema("dbo"); // Default schema, istənilən schema adı ilə əvəz oluna bilər
            modelBuilder.UseCollation("Latin1_General_CI_AS");
        }
       
    }
}

