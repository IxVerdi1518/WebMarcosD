using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebMarcosD.Models;
using WebMarcosD.Session;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebMarcosD.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesApiController : ControllerBase
    {
        // GET: api/<ClientesApiController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {

            var cliente = new List<Cliente>
            {
            new Cliente{Identificacion="1",Nombres="Harry",Apellidos="Potter" },
            new Cliente{Identificacion="2",Nombres="Pepe",Apellidos="Grillo" }
            };
            return cliente;
        }


        // GET api/<ClientesApiController>/5
        [HttpGet]
        [Route("[controller]/ListarID/{id}")]
        public Cliente Get(int id)
        {
            var cliente = new List<Cliente>
            {
            new Cliente{Identificacion="1",Nombres="Harry",Apellidos="Potter" },
            new Cliente{Identificacion="2",Nombres="Pepe",Apellidos="Grillo" }
            };
            return cliente.ElementAt(id);
        }

        // POST api/<ClientesApiController>
        [HttpPost]
        [Route("[controller]/guardar/")]
        public Cliente Post([FromBody] Cliente cliente)
        {
            Console.WriteLine("Post Method");
            Console.WriteLine("Identificacion"+cliente.Identificacion);
            Console.WriteLine("Apellidos"+cliente.Apellidos);
            Console.WriteLine("Nombres"+cliente.Nombres);
            return cliente;
        }

        // PUT api/<ClientesApiController>/5
        [HttpPut]
        [Route("[controller]/update/{id}")]
        public void Put(int id, [FromBody] Cliente cliente)
        {
            var cliente1 = new List<Cliente>
            {
                new Cliente { Identificacion = "1",Nombres = "Harry", Apellidos = "Potter"},
                new Cliente { Identificacion = "2", Nombres = "Pepe", Apellidos = "Rajo"},
            };
            cliente1.RemoveAt(id);
            Console.WriteLine("Identificacion" + cliente.Identificacion);
            Console.WriteLine("Apellidos" + cliente.Apellidos);
            Console.WriteLine("Nombres" + cliente.Nombres);
        }

        // DELETE api/<ClientesApiController>/5
        [HttpDelete]
        [Route("[controller]/delete/{id}")]
        public void Delete(int id)
        {
            var cliente = new List<Cliente>
            {
                new Cliente { Identificacion = "1",Nombres = "Harry", Apellidos = "Potter"},
                new Cliente { Identificacion = "2", Nombres = "James", Apellidos = "Rajo"},
            };
            //var jsonString = JsonSerializer.Serialize(cliente);
            cliente.RemoveAt(id);
        }
    }
}
