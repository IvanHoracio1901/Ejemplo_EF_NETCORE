using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejemplo_EF_NETCORE.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejemplo_EF_NETCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController1 : ControllerBase
    {
        private readonly ICancionService _cancionService;
        private readonly IAutor _autorService;
        private readonly IAlbumService _albumService; 

        public ValuesController1(ICancionService cancionService, IAutor autorService, IAlbumService albumService)
        {
            _cancionService = cancionService;
            _autorService = autorService;
            _albumService = albumService;

        }
        // GET: api/<ValuesController1>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //_cancionService.AddCancion(new Models.Cancion
            //{
            //    Descripcion = "Asereje ja de je",
            //    Duracion = new TimeSpan(0,4,25),
            //    Titulo = "Aserje"
            //});

            //var canciones = _cancionService.GetCanciones();

            //var cancion = _cancionService.GetCancion(1);

            //cancion.Descripcion = "Entidad Cambiada";

            //_cancionService.UpdateCancion(cancion);

            //_cancionService.DeleteCancion(2);

            _albumService.AddAlbum(new Models.Album
            {
                Nombre = "Album1"
            });

            _autorService.AddAutor(new Models.Autor
            {
                Nombre = "Jose Gomez"
            });

            _cancionService.AddCancion(new Models.Cancion
            {
                AutorId = 1,
                AlbumId = 1,
                Descripcion = "Cancion de mujeres",
                Titulo = "Titulo1",
                Duracion = new TimeSpan(0, 3, 36)
            });

            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
