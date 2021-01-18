using Microsoft.EntityFrameworkCore;
using Pro.Domain;

namespace Pro.Repository
{
    public class ProContext : DbContext
    {
        public ProContext (DbContextOptions<ProContext> options): base (options) {}
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<PalestranteEvento> PalestranteEventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<RedeSocial> RedeSociais { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE => new { PE.EventoId, PE.PalestranteId});
        }
        
    }
}