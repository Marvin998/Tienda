using Microsoft.EntityFrameworkCore;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class DatosBD : DbContext
    {
        public DatosBD(DbContextOptions<DatosBD> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasKey(p => p.IdProducto);

            modelBuilder.Entity<Producto>()
               .Property(p => p.Precio)
               .HasPrecision(18,2);
        }
    }
}
