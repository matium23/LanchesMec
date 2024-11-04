using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Contexto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Option): base(Option)
        {            
        }

        public DbSet<Lanche>Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
