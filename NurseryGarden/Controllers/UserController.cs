using Microsoft.AspNetCore.Mvc;
using NurseryGarden.Models;
using NurseryGarden.Services;

namespace NurseryGarden.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Create()
		{
			return View();
		}

		public IActionResult ShowDetails(UserModel userModel)
		{
			UserDAO userDAO = new UserDAO();
			if(userDAO.CheckIfNotUsed(userModel))
			{
                return View(userModel);
            }
			else
			{
				ViewBag.Address = "Address is already used";
				return View("Create");
			}

            
		}

		public IActionResult AcceptCreate(UserModel userModel)
		{
			UserDAO userDAO = new UserDAO();
			if (userDAO.InsertIntoDB(userModel))
			{
				return View("SuccessCreated");
			}
			else
			{
				return View("Index");
			}
		}

		public IActionResult SuccessCreated()
		{
			return View();
		}
	}
}
