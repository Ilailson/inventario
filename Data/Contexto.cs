using Microsoft.EntityFrameworkCore;
using Inventario.Models;

namespace Inventario.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Sala> Sala { get; set; }

    }
}
