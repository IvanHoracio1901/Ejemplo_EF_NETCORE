using Ejemplo_EF_NETCORE.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.EntityConfig
{
    public class CancionEntityConfig
    {
        public static void SetCancionEntityConfig(EntityTypeBuilder<Cancion> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.CancionId);
            entityTypeBuilder.Property(x => x.Titulo);
            entityTypeBuilder.Property(x => x.Descripcion);
        }
    }
}
