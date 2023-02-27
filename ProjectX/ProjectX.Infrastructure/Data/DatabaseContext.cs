using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectX.Core.Entities;

namespace ProjectX.Infrastructure.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Master> Masters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Master>(ConfigureMaster);
        }

        private void ConfigureMaster(EntityTypeBuilder<Master> builder)
        {
            builder.ToTable("Masters");

            builder.HasKey(ci => ci.Id);

            builder.Property(cb => cb.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(cb => cb.MiddleName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(cb => cb.Surname)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
