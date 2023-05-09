using System.ComponentModel.DataAnnotations;

namespace PeopleManager.Ui.Mvc.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Display(Name ="First Name")]//Dit doet niks met de code, dit is meer voor het renderen van het formulier makkelijker te maken.
        [Required]
        public required string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public required string LastName { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        [Required]//required: voor userinterface
        public required string Email { get; set; }//required voor programmeur in code

        [Display(Name = "Description")]
        public string? Description { get; set; }
    }
}
