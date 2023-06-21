using Microsoft.AspNetCore.Mvc;
using Shop_Task_MVC.Models;
using System.Diagnostics;

namespace Shop_Task_MVC.Controllers
{
    public class HomeController : Controller
    {
        private static List<Shop> shop = new List<Shop>
        {
            new Shop
            {
                Id = 1,
                Name = "Olma",
                Price = 14000
            }
        };

        public IActionResult Index()
        {
            return View(shop);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View(shop);
        }
        [HttpPost]
        public IActionResult Add(Shop shoping)
        {
            return View(shop);
        }


    }
}