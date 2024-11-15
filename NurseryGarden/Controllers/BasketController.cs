using Microsoft.AspNetCore.Mvc;
using NurseryGarden.Models;
using NurseryGarden.Services;

namespace NurseryGarden.Controllers
{
    public class BasketController : Controller
    {
        BasketDAO basketDAO = new BasketDAO();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowBasket(UserModel userModel)
        {
            return View(basketDAO.ShowBasket(userModel));
        }
    }
}
