using Ejemplo_EF_NETCORE.EntityConfig;
using Ejemplo_EF_NETCORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Contexto
{
    public class ContextoDB : DbContext, IContextoDB
    {
        public ContextoDB(DbContextOptions<ContextoDB> options) : base(options)
        {

        }
        //Una manera de crear una tabla para migraciones con entity
        public DbSet<Cancion> Canciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CancionEntityConfig.SetCancionEntityConfig(modelBuilder.Entity<Cancion>());
            //Otra manera de crear una tabla para migraciones con entity
            //modelBuilder.Entity<Cancion>().ToTable("Canciones");
            //Despues de tener esto hay que ingresa a la CONSOLA DEL ADMINISTRADOR DE PAQUETES e ingresar Add-Migration nombre de la migracion
        }
    }
}
