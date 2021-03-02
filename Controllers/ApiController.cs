using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        [HttpGet]   // GET /api/test2
        public IActionResult ListProducts()
        {
            return View();
        }

        [HttpGet("{id}")]   // GET /api/test2/xyz
        public IActionResult GetProduct(string id)
        {
        return View(id);
        }

        [HttpGet("int/{id:int}")] // GET /api/test2/int/3 (sólo int)
        public IActionResult GetIntProduct(int id)
        {
            return View(id);
        }

        [HttpGet("int2/{id}")]  // GET /api/test2/int2/3
        public IActionResult GetInt2Product(int id)
        {
            return View(id);
        }

        [HttpGet("/api/{id}", Name = "Products_List")] //Nombre de ruta
        public IActionResult GetProduct(int id)
        {
            return View(id);
        }

        [Route("")]
        [Route("Home", Order = 2)] //orden para cuando hay más de un controlador con esta ruta y resolver ambigüedad
        [Route("Home/MyIndex")]
        public IActionResult MyIndex()
        {
            return View();
        }
        
    }
}
