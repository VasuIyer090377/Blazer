using Microsoft.EntityFrameworkCore;

namespace MyShop.Api.Models
{
    public class MyshopContext : DbContext
    {
        public MyshopContext()
        {
        }

        public MyshopContext(DbContextOptions<MyshopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advertisement> Advertisement { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.Property(e => e.CreationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(true);

                entity.Property(e => e.ExpirationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(true);
            });
        }
    }
}