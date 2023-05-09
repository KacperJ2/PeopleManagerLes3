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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var person = _database.People.Find(id);
            {
                if (person == null) 
                {
                    return RedirectToAction("Index");
                }
            }
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute]int id, Person person)
        {
            var dbPerson = _database.People.Find(id);
            {
                if(dbPerson == null)
                {
                    return RedirectToAction("Index");
                }
            }
            dbPerson.FirstName =person.FirstName;
            dbPerson.LastName =person.LastName;
            dbPerson.Email =person.Email;
            dbPerson.Description =person.Description;


            _database.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
