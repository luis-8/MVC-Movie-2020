using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.ViewModels;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        [ViewData]
        public string atrVD { get; set; }

        //
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            atrVD = "Este es un atributo ViewData llamado atrVD";

            var viewModel = new Address()
            {
                Name = "Microsoft",
                Street = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                PostalCode = "98052-6399"
            };

            ViewData["Address"]  = new Address()
            {
                Name = "Steve",
                Street = "123 Main St",
                City = "Hudson",
                State = "OH",
                PostalCode = "44236"
            };

            return View(viewModel);
        }

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        [Route("bienvenido")]
        [Route("bienvenido/{name?}")]
        public IActionResult Otro(string? name="tino")
        {
            return Json(new[] { new { Id = 1, Nombre = "Dato 1"}, new { Id=2, Nombre="Dato 2"} });            
            //return Json(new{name=name, tel="123"});
        }
    }
}