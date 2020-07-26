using Ejemplo_EF_NETCORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Contexto
{
    public interface IContextoDB
    {
        DbSet<Cancion> Canciones { get; set; }
        DbSet<Album> albums { get; set; }
        DbSet<Autor> autor { get; set; }
        int SaveChanges();
        Task<int> SaveChangeAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}
