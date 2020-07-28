using Ejemplo_EF_NETCORE.Contexto;
using Ejemplo_EF_NETCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Service
{
    public class AutorService : IAutor
    {
        private readonly IContextoDB _contextoDB;

        public AutorService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddAutor(Autor autor)
        {
            _contextoDB.autor.Add(autor);

            _contextoDB.SaveChanges();

        }
        //CRUD
        public void DeleteAutor(int AutorId)
        {
            var autor = GetAutor(AutorId);
            DeleteAutor(autor);
        }
        public void DeleteAutor(Autor Autor)
        {
            _contextoDB.autor.Remove(Autor);
            _contextoDB.SaveChanges();
        }
        public List<Autor> GetAutor()
        {
            return _contextoDB.autor.Select(x => x).ToList();
        }

        public Autor GetAutor(int AutorId)
        {
            return _contextoDB.autor.Where(x => x.AutorId == AutorId).FirstOrDefault();
        }

        public Autor UpdateAutor(Autor autor)
        {
            //var cancionAux = GetCancion(cancion.CancionId);
            var autorUpdate = _contextoDB.autor.Update(autor).Entity;
            _contextoDB.SaveChanges();
            return autorUpdate;
        }
    }
}
