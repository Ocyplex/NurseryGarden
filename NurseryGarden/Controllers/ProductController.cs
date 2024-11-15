using Microsoft.AspNetCore.Mvc;
using NurseryGarden.Models;
using NurseryGarden.Services;

namespace NurseryGarden.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllProducts()
        {
            ProductDAO productsDAO = new ProductDAO();
            return View(productsDAO.GetAllProductToList());
        }

        public IActionResult AddProductToBasket()
        {

            return View();
        }

    }
}
