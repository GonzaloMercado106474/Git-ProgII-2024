using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiRest1w3.Models;

namespace WebApiRest1w3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> products = new List<Product>
    {
        new Product { Code = 1, Name = "Pan" },
        new Product { Code = 2, Name = "Queso" }
    };

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(products);
        }
    }
}


/*[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    // ─────────────────────────────────────────────────────────────
    // VERSION ANTERIOR (mal). La dejo anotada para no repetirla.
    //
    // private static readonly List<Product> products = new List<Product>();
    //
    // [HttpGet]
    // public IActionResult Gets()
    // {
    //     products.Add(new Product { Code = 1, Name = "Pan" });
    //     products.Add(new Product { Code = 2, Name = "Queso" });
    //     return Ok(products);
    // }
    //
    // POR QUE ESTABA MAL:
    // Los Add estaban DENTRO del metodo, asi que se ejecutaban en CADA
    // peticion GET. Cada vez que consultaba, agregaba dos productos mas:
    // el JSON se duplicaba a cada llamada.
    //
    // Ademas rompia la regla del protocolo: un GET no debe causar efectos
    // secundarios en el servidor, no debe producir nuevos registros ni
    // modificar los existentes. Ese GET modificaba la lista.
    //
    // LA CORRECCION: no cambia QUE se hace, cambia CUANDO. Los productos
    // se cargan en la declaracion de la lista, que al ser static se crea
    // una sola vez para toda la aplicacion.
    // ─────────────────────────────────────────────────────────────

    private static readonly List<Product> products = new List<Product>
    {
        new Product { Code = 1, Name = "Pan" },
        new Product { Code = 2, Name = "Queso" }
    };

    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(products);
    }
}*/