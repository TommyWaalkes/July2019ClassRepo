using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirst
{
    public partial class CatsContext : DbContext
    {
        public CatsContext()
        {
        }

        public CatsContext(DbContextOptions<CatsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cat> Cat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-FPF5GBKU\\SQLEXPRESS;Initial Catalog=Cats;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>(entity =>
            {
                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(20);
            });
        }
    }
}
