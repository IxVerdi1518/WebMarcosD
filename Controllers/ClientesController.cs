using Microsoft.AspNetCore.Mvc;
using WebMarcosD.Models;
using WebMarcosD.Session;

namespace WebMarcosD.Controllers
{
    public class ClientesController : Controller



    {
        List<Cliente> list = new List<Cliente>();

        public ClientesController()
        {
            Console.WriteLine("ClientesController Constructor");
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Crear()
        {

            return View();
        }

        public IActionResult Editar()
        {

            return View();
        }

        [Route("Clientes/Eliminar/{identificacion}")]
        public IActionResult Eliminar(String identificacion)
        {
            if (list == null)
                list = new List<Cliente>();
            Cliente cliente = new Cliente();
            foreach (Cliente cl in list)
            {
                if (cl.Identificacion == identificacion)
                {
                    cliente = cl;

                }
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult EliminarPage(Cliente cliente)
        {
            List<Cliente> list = SessionHelper.GetObjectFromJson<List<Cliente>>(HttpContext.Session, "clientes");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Identificacion == cliente.Identificacion)
                {
                    list.Remove(list[i]);

                }
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "clientes", list);
            return RedirectToAction("ClientesAc");
        }
        [HttpPost]
        public IActionResult EditarPage(Cliente cliente)
        {
            List<Cliente> list = SessionHelper.GetObjectFromJson<List<Cliente>>(HttpContext.Session, "clientes");

            for (int i = 0; i < list.Count; i++)
            {
                list.Remove(list[i]);
                list.Add(cliente);
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "clientes", list);
            return RedirectToAction("ClientesAc");
        }

        [HttpPost]
        public IActionResult Guardar(Cliente cliente)
        {
            List<Cliente> list = SessionHelper.GetObjectFromJson<List<Cliente>>(HttpContext.Session, "clientes");
            if (list == null)
                list = new List<Cliente>();
            list.Add(cliente);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "clientes", list);
            Console.WriteLine("add cliente");

            return RedirectToAction("ClientesAc");
        }

        public IActionResult ClientesAc()
        {
            return View(ListaClientes());
        }

        public List<Cliente> ListaClientes()
        {
            List<Cliente> list = SessionHelper.GetObjectFromJson<List<Cliente>>(HttpContext.Session, "clientes");
            if (list == null)
                list = new List<Cliente>();
            return list;
        }

    }
}