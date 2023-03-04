using Microsoft.EntityFrameworkCore;

namespace Inventario.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Sala> Sala { get; set; }
        public DbSet<Monitore> Monitor { get; set; }

        public DbSet<Memoria> Memoria { get; set; }

    }
}
