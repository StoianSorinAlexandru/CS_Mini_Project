using Microsoft.EntityFrameworkCore;
using miniProiect.Models;

namespace miniProiect.Data
{
    public class MiniProjectContext : DbContext
    {
        public MiniProjectContext(DbContextOptions<MiniProjectContext> options) :base(options) { }
        
        public DbSet<Produs> Produse { get; set; }

        public DbSet<Partener> Partener { get; set; }

        public DbSet<Gestiune> Gestiune { get; set; }

    }
}
