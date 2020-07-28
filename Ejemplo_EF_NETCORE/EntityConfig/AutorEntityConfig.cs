using Ejemplo_EF_NETCORE.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.EntityConfig
{
    public class AutorEntityConfig
    {
        public static void SetCancionEntityConfig(EntityTypeBuilder<Autor> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.AutorId);
            entityTypeBuilder.Property(x => x.Nombre).IsRequired();
        }
    }
}
