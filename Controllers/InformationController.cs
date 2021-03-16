using FirstWeb.Interface;
using FirstWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers
{
    public class InformationController : Controller
    {   
        private readonly IRentInformationService _repo;
        public InformationController(
            IRentInformationService repo 
        )
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var model = _repo.GetAllPersons();
            return View(model);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Person model)
        {
            if (ModelState.IsValid) {
                var person = _repo.AddPerson(model);
                ViewBag.SuccessMessage = "Details Added Successfully";
                return View();
            }
            else {
                ViewBag.Err = "Please check your values";
            }
            return View();
            
        }

        public IActionResult Person(string Id)
        {
            var person = _repo.GetOnePerson(Id);
            return View(person);
        }
        public IActionResult Update(string Id)
        {
            var person = _repo.GetOnePerson(Id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Update(Person model)
        {
            var person = _repo.UpdatePerson(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string Id)
        {
            var person = _repo.GetOnePerson(Id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Delete(Person model)
        {
            var person = _repo.DeletePerson(model);
            return RedirectToAction("Index");
        }
    }
}