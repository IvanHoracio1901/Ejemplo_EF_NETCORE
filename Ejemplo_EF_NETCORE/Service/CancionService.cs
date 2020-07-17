using Ejemplo_EF_NETCORE.Contexto;
using Ejemplo_EF_NETCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Service
{
    public class CancionService: ICancionService
    {
        private readonly IContextoDB _contextoDB;

        public CancionService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddCancion(Cancion cancion)
        {
            _contextoDB.Canciones.Add(cancion);

            _contextoDB.SaveChanges();
            
        }
    }
}
