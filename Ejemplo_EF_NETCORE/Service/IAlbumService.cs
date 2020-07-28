using Ejemplo_EF_NETCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Service
{
    public interface IAlbumService
    {

        void AddAlbum(Album Album);
        void DeleteAlbum(int AlbumId);
        void DeleteAlbum(Album Album);
        List<Album> GetAlbum();
        Album GetAlbum(int AlbumId);
        Album UpdateAlbum(Album album);
    }
}
