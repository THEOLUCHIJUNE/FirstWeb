using FirstWeb.Interface;
using FirstWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers
{
    public class NairaToDollarController : Controller
    {
        private readonly IConvertToDollars _repo;

        public NairaToDollarController(IConvertToDollars repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Convert(CalculateDollar model)
        {
            var result = _repo.Convertnaira(model);

            ViewBag.ModelNaira = model.Naira;
            ViewBag.ModelExchangeRate = 432;
            ViewBag.CalculateResult = result;
            return View();
        }
    }
}