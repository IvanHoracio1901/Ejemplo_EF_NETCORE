using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Models
{
    public class Cancion
    {
        public int CancionId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan Duracion { get; set; }

        //Relacionar Cancion con Album

        public Album Album { get; set; }
        public int AlbumId { get; set; }

        //Relacionar Cancion con Autor
        public Autor Autor { get; set; }
        public int AutorId { get; set; }
    }
}
