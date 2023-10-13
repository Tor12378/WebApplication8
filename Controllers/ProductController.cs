using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Товар 1", Description = "Описание товара 1", Price = 10.0M },
            new Product { Id = 2, Name = "Товар 2", Description = "Описание товара 2", Price = 20.0M },
            new Product { Id = 3, Name = "Товар 3", Description = "Описание товара 3", Price = 30.0M },
            new Product { Id = 4, Name = "Товар 4", Description = "Описание товара 4", Price = 40.0M },
            new Product { Id = 5, Name = "Товар 5", Description = "Описание товара 5", Price = 50.0M }
        };
        public IActionResult List()
        {
           
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var product = new Product
            {
                Id = id,
                Name = "Товар " + products[id].Name,
                Description = "Описание товара " + products[id].Description,
                Price = products[id].Price
            };

            return View(product);
        }
    }
}
