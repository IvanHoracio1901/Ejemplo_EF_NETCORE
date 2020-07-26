using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }

        //Relacionar Autor con Cancion
        public Cancion Cancion { get; set; }
    }
}
