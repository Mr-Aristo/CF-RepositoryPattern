using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class MonitorsContext : DbContext
    {
        public MonitorsContext()
            : base("name=MonitorsContext")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Suplier> Supliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(e => e.TotalCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Suplier>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Suplier>()
                .Property(e => e.ContactName)
                .IsUnicode(false);
        }
    }
}
