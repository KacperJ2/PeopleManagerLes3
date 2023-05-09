using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        private IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person{FirstName = "Bavo", LastName = "Ketels", Email = "bavo.ketels@vives.be" },
                new Person{FirstName = "Isabelle", LastName = "Vandoorne", Email = "isabelle.vandoorne@vives.be" },
                new Person{FirstName = "Wim", LastName = "Engelen", Email = "wim.engelen@vives.be" },
                new Person{FirstName = "Ebe", LastName = "Deketelaere", Email = "ebe.deketelaere@vives.be" }
            };
        }
    }
}
