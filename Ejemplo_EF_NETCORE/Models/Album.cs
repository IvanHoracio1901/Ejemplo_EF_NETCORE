using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Nombre { get; set; }

        //Relacionar Album con cancion
        public List<Cancion> Cancions { get; set; }
    }
}
