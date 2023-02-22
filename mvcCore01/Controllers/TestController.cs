using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvcCore01.Controllers
{
    public class TestController : Controller //El nombre de la clase debe terminar con Controller. No así el nombre del archivo. No sé si la ubicación importa.
    {
        //
        // GEt: /HelloWord/

        //public string Index() // Método sin vistas
        //{
        //    return "This is my default action...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Temp()
        {
            return View();
        }

        //
        // GET: /HelloWord/Welcome/

        //public string Welcome() // Método sin parámetros.
        //{
        //    return "This is the Welcome action method...";
        //}

        public string Welcome(string name, int ID = 1) //Método con parámetros.
        //Funciona de esta manera
        //https://localhost:7172/test/welcome?name=javier&ID=25
        //Pero como en Program.cs está definido: pattern: "{controller=Home}/{action=Index}/{id?}");
        //Tambien funciona:
        //https://localhost:7172/test/welcome/25/?name=javier
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
