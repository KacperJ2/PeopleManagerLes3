using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Core;
using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleManagerDataBase _database;
        public PeopleController(PeopleManagerDataBase database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            var people = _database.People;
            return View(people);
        }
    }
}
