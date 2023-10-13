using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Товар 1", Description = "Описание товара 1", Price = 10.0M },
            new Product { Id = 2, Name = "Товар 2", Description = "Описание товара 2", Price = 20.0M },
            new Product { Id = 3, Name = "Товар 3", Description = "Описание товара 3", Price = 30.0M },
            new Product { Id = 4, Name = "Товар 4", Description = "Описание товара 4", Price = 40.0M },
            new Product { Id = 5, Name = "Товар 5", Description = "Описание товара 5", Price = 50.0M }
        };

            return View(products);
        }
        public IActionResult About()
        {
            var store = new Store
            {
                Name = "Наш Магазин",
                Description = "Лучший магазин в мире!"
            };

            return View(store);
        }
    }
}