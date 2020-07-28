using Ejemplo_EF_NETCORE.Contexto;
using Ejemplo_EF_NETCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Service
{
    public class AlbumService : IAlbumService
    {
        private readonly IContextoDB _contextoDB;

        public AlbumService(IContextoDB contextoDB)
        {
            _contextoDB = contextoDB;
        }

        public void AddAlbum(Album Album)
        {
            _contextoDB.albums.Add(Album);

            _contextoDB.SaveChanges();

        }
        //CRUD
        public void DeleteAlbum(int AlbumId)
        {
            var album = GetAlbum(AlbumId);
            DeleteAlbum(album);
        }
        public void DeleteAlbum(Album Album)
        {
            _contextoDB.albums.Remove(Album);
            _contextoDB.SaveChanges();
        }
        public List<Album> GetAlbum()
        {
            return _contextoDB.albums.Select(x => x).ToList();
        }

        public Album GetAlbum(int AlbumId)
        {
            return _contextoDB.albums.Where(x => x.AlbumId == AlbumId).FirstOrDefault();
        }

        public Album UpdateAlbum(Album album)
        {
            //var cancionAux = GetCancion(cancion.CancionId);
            var albumUpdate = _contextoDB.albums.Update(album).Entity;
            _contextoDB.SaveChanges();
            return albumUpdate;
        }
    }
}
