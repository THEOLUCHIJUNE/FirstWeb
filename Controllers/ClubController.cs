using Microsoft.AspNetCore.Mvc;
using FirstWeb.Interface;
using FirstWeb.Models;

namespace FirstWeb.Controllers
{
    public class ClubController : Controller
    {
        private readonly IAge _repo;

        public ClubController(IAge repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult agechecker(Age model)
        {
            var result = _repo.CheckAge(model);

            ViewBag.ModelAgeOfCustomer = model.AgeOfCustomer;
            ViewBag.ModelBelowEighteen = "Apologies, you are too young to be here.";
            ViewBag.ModelAboveEighteen = "Hey There. What drink would you like to order? ";
            return View();
        }
    }
}