using Microsoft.EntityFrameworkCore;
using RepasoCubos.Models;

namespace RepasoCubos.Data
{
    public class CubosContext: DbContext
    {
        public CubosContext(DbContextOptions<CubosContext> options) : base(options) { } 

        public DbSet<Cubo> Cubos { get; set; }
        public DbSet<VistaCubos> VistaCubos { get; set; }
        public DbSet<string> Marcas { get; set; }
        public DbSet<ModelPaginacionCubos> ModelCubosPaginados { get; set; }
    }
}
