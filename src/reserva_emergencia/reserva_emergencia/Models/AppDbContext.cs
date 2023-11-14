using Microsoft.EntityFrameworkCore;

namespace reserva_emergencia.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Reserva> Reservas { get; set; } // Informando qual será o banco de dados 
    }
}
