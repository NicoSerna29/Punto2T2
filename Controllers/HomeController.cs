using Microsoft.AspNetCore.Mvc;

namespace Punto2T2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        public static List<Producto> productos = new List<Producto>()
        {
            new Producto
            {
                nombre = "jabon",
                codigo = "A21",
                precio = 1500.50,
                estado = true
            },
            new Producto
            {
                nombre = "jabon",
                codigo = "A21",
                precio = 1500.50,
                estado = true
            }
        };
        [HttpGet("Consultar")]
        public List<Producto> Consultar()
        {
            return productos;
        }


        [HttpGet("Consultar 2")]
        public string Consultar2()
        {
            return "Hola Mundo 2";
        }
    }
}
