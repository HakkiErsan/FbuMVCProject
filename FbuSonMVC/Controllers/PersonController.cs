using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FbuSonMVC.Controllers
{
    public class PersonController : Controller
    {
        PersonManager personManager = new PersonManager(new InMemoryPersonDal());
        public IActionResult Index()
        {
            return View(personManager.GetPeople());
        }

        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
           
            personManager.AddPeople(person);
            return RedirectToAction("Index");
        }
    }
}
