using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        // Estos son los nombres de las tablas en la base de datos
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Esta es la declaracion de foreign keys
            builder.Entity<Portfolio>(x => x.HasKey(p => new { p.AppUserId, p.StockId }));

            // Declaracion de las relaciones
            builder.Entity<Portfolio>()
                .HasOne(u => u.AppUser) // Un usuario
                .WithMany(u => u.Portfolios) // Tiene muchos portafolios
                .HasForeignKey(u => u.AppUserId); // y su foreign key es

            builder.Entity<Portfolio>()
                .HasOne(s => s.Stock)
                .WithMany(s => s.Portfolios)
                .HasForeignKey(s => s.StockId);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}