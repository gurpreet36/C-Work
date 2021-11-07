using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace phonebook.Models
{
    public partial class PhonebookDbContext : DbContext
    {
        public PhonebookDbContext()
        {
        }

        public PhonebookDbContext(DbContextOptions<PhonebookDbContext> options): base(options)
        {
        }

        public virtual DbSet<PhoneBook> PhoneBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=PhonebookDb;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_India.1252");

            modelBuilder.Entity<PhoneBook>(entity =>
            {
                entity.ToTable("PhoneBook");

                entity.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
