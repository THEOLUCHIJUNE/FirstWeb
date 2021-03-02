using Microsoft.AspNetCore.Mvc;
using FirstWeb.Interface;
using FirstWeb.Models;

namespace FirstWeb.Controllers
{
    public class TellController : Controller
    {
        private readonly ICheckLegalAge _repo;

        public TellController(ICheckLegalAge repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgeChecker(TellAge model)
        {
            var result = _repo.CheckLegalAgeForPass(model);

            ViewBag.ModelAge = model.Age;
            ViewBag.ModelBelowEighteen = "Apologies, you are too young to be here.";
            ViewBag.ModelAboveEighteen = "Hey There. What drink would you like to order? ";
            return View();
        }
    }
}