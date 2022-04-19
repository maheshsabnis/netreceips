using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SharedModels.Models;
namespace API_App.Models
{
    public partial class ApiDbContext : DbContext
    {
        public ApiDbContext()
        {
        }

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryRowId);

                entity.Property(e => e.CategoryId).HasMaxLength(50);

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductRowId);

                entity.HasIndex(e => e.CategoryRowId, "IX_Products_CategoryRowId");

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.HasOne(d => d.CategoryRow)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryRowId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
