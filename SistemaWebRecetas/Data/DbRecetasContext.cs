using Microsoft.EntityFrameworkCore;
using SistemaWebRecetas.Models;

namespace SistemaWebRecetas.Data
{
    public class DbRecetasContext : DbContext
    {
        public DbRecetasContext(DbContextOptions<DbRecetasContext> options) : base(options)
        {
        }
        public DbSet<Receta> Recetas { get; set; }
    }
}
