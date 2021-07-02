using Tecnologico.Server.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Tecnologico.Shared.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tecnologico.Server.Controllers
    //Controlador API de libros
{
    [Route("api/[controller]")] //ruta de la API
    [ApiController]
    public class DatosController : ControllerBase
    {
        private TecnologicosContext _context;
        public DatosController(TecnologicosContext context)
        {
            _context = context; 
            //Objeto apuntador con el que se dirige la informacion por los metodos HTTP
        }

        // GET: api/<BooksController>
        // Metodo GET para la obtencion de datos.
        [HttpGet]
        public object Get()
        {
            return new { Items = _context.Datos, Count = _context.Datos.Count() };
        }

        // POST api/<BooksController>
        // Metodo POST para el envio de datos a la tabla
        [HttpPost]
        public void Post([FromBody] Dato dato)
        {
            _context.Datos.Add(dato);
            _context.SaveChanges();
        }

        // PUT api/<BooksController>
        // Metodo PUT para la obtencion de Datos para la tabla
        [HttpPut]
        public void Put(long id, [FromBody] Dato dato)
        {
            Dato _dato = _context.Datos.Where(x => x.Id.Equals(dato.Id)).FirstOrDefault();
            _dato.NombreCliente = dato.NombreCliente;
            _dato.Producto = dato.Producto;
            _dato.Precio = dato.Precio;
            _dato.Stock = dato.Stock;
            _context.SaveChanges();
        }

        // DELETE api/<BooksController>
        // Metodo para eliminacion de Columna, elimina la columna del ID seleccionado
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            Dato _dato = _context.Datos.Where(x => x.Id.Equals(id)).FirstOrDefault();
            _context.Datos.Remove(_dato);
            _context.SaveChanges();
        }
    }
}
