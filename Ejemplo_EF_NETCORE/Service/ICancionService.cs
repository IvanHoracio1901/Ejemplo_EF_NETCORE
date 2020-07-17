using Ejemplo_EF_NETCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Service
{
    public interface ICancionService
    {
        void AddCancion(Cancion cancion);
    }
}
