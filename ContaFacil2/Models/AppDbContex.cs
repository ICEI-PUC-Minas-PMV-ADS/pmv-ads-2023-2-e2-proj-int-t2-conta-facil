using Microsoft.EntityFrameworkCore;

namespace ContaFacil2.Models
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options) { }
        public DbSet<Cadastro> Cadastros { get; set; }
    }
}
