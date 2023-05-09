using PeopleManager.Ui.Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace PeopleManager.Ui.Mvc.Core
{
    public class PeopleManagerdbContext : DbContext
    {

        public PeopleManagerdbContext(DbContextOptions<PeopleManagerdbContext> options): base(options)
        {

        }

        public DbSet<Person> People => Set<Person>();

        public void Seed()
        {
            People.AddRange(new List<Person>           
            {
                new Person { Id = 1, FirstName = "Kacper", LastName = "Juras", Email = "kacper.juras@student.vives.be" },
                new Person { Id = 2, FirstName = "Qendrim", LastName = "Selmani", Email = "qendrim.selmani@student.vives.be" },
                new Person { Id = 3, FirstName = "Jona", LastName = "Depressed", Email = "jona.depressed@student.vives.be" },
                new Person { Id = 4, FirstName = "Aaron", LastName = "Carreyn", Email = "aaron.carreyn@student.vives.be" }
            });

            SaveChanges();
        }
    }
}
