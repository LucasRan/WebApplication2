using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product {
            ProductId = 1,
            Name = "kAYAK",
            Description = "A boat for one person",
            Price = 275M,
            Category = "WATER SPORTS"
        };

        public IActionResult Index()
        {
            return View();
        }
    }
}