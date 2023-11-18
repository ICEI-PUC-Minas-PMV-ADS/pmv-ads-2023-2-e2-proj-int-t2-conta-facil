using Microsoft.EntityFrameworkCore;

namespace ContaFacil2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Cadastro> Cadastros { get; set; }
        public DbSet<Saldo> Saldos { get; set; }
        public DbSet<Reserva> Reservas { get; set; } // Informando qual será o banco de dados 
    }
}
