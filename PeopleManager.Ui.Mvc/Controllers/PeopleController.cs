using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeopleManager.Ui.Mvc.Core;
using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleManagerdbContext _database;
        public PeopleController(PeopleManagerdbContext database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            var people = _database.People.ToList();
            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            _database.People.Add(person);
            _database.SaveChanges(); 
            return RedirectToAction("Index");
        }
    }
}
