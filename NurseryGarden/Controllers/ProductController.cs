using Microsoft.AspNetCore.Mvc;
using NurseryGarden.Models;
using NurseryGarden.Services;

namespace NurseryGarden.Controllers
{
    public class ProductController : Controller
    {
        ProductDAO productsDAO = new ProductDAO();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllProducts()
        {
            
            return View(productsDAO.GetAllProductToList());
        }

        public IActionResult AddProductToBasket()
        {

            return View();
        }

        public IActionResult ShowProduct(int id)
        { 
            var product = productsDAO.ShowProductByID(id);
            return View(product); 
        }

      

    }
}
