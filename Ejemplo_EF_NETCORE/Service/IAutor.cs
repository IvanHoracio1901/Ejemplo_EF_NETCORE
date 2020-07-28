using Ejemplo_EF_NETCORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplo_EF_NETCORE.Service
{
    public interface IAutor
    {
        void AddAutor(Autor autor);
        void DeleteAutor(int AutorId);
        void DeleteAutor(Autor Autor);
        List<Autor> GetAutor();
        Autor GetAutor(int AutorId);
        Autor UpdateAutor(Autor autor);
    }
}
