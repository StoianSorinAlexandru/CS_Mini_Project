using Microsoft.EntityFrameworkCore;
using miniProiect.Models;

namespace miniProiect.Data
{
    public class MiniProjectContext : DbContext
    {
        public MiniProjectContext(DbContextOptions<MiniProjectContext> options) :base(options) { }
        
        // Modelele principale
        public DbSet<Produs> Produse { get; set; }

        public DbSet<Partener> Partener { get; set; }

        public DbSet<Gestiune> Gestiune { get; set; }

        public DbSet<Intrari> Intrari { get; set; }

        public DbSet<IntrariDetaliu> IntrariDetaliu { get; set; }


        // Modele de legatura in bd
        public DbSet<IntrariDetaliuProdus> IntrariDetaliuProdus { get; set; }

        public DbSet<IntrariGestiune> intrariGestiunes { get; set; }

        public DbSet<IntrariParteneri> intrariParteneris { get; set; }

    }
}
