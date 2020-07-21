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
        //CRUD
        public void DeleteCancion(int CancionId)
        {
            var cancion = GetCancion(CancionId);
            DeleteCancion(cancion);
        }
        public void DeleteCancion(Cancion cancion)
        {
            _contextoDB.Canciones.Remove(cancion);
            _contextoDB.SaveChanges();
        }
        public List<Cancion> GetCanciones()
        {
            return _contextoDB.Canciones.Select(x => x).ToList();
        }

        public Cancion GetCancion(int CancionId)
        {
            return _contextoDB.Canciones.Where(x => x.CancionId == CancionId).FirstOrDefault();
        }

        public Cancion UpdateCancion(Cancion cancion)
        {
            //var cancionAux = GetCancion(cancion.CancionId);
            var cancionUpdate = _contextoDB.Canciones.Update(cancion).Entity;
            _contextoDB.SaveChanges();
            return cancionUpdate;
        }
    }
}
