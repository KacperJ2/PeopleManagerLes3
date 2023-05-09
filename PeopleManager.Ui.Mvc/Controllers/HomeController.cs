using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;
using System.Diagnostics;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [HttpGet("Home/Detail/{id:int}")]
        public IActionResult Detail(int id)           
        {
            var people = GetPeople();
            var person = people.FirstOrDefault(p => p.Id == id);

            if(person is null)
            {
                return RedirectToAction("Index");
            }
            //Roept view PErsonDetail op ook al is de action naam niet hetzelfde door het in de return view te zetten vindt hij en nu wel.
            return View("PersonDetail", person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person{Id= 1, FirstName = "Kacper", LastName = "Juras", Email = "kacper.juras@student.vives.be" },
                new Person{Id= 2, FirstName = "Qendrim", LastName = "Selmani", Email = "qendrim.selmani@student.vives.be" },
                new Person{Id= 3, FirstName = "Jona", LastName = "Depressed", Email = "jona.depressed@student.vives.be" },
                new Person{Id= 4, FirstName = "Aaron", LastName = "Carreyn", Email = "aaron.carreyn@student.vives.be"}
            };
        }
    }
}