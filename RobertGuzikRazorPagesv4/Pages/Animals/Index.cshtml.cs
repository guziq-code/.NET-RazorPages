
using RobertGuzikRazorPagesv4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RobertGuzikRazorPagesv4.Pages.Animals
{
    public class IndexModel : PageModel
    {
        AnimalContext animalContext = new AnimalContext();
        public List<Animal> Animals { get; set; }


        public void OnGet()
        {
            Animals = animalContext.Animals.ToList();
        }
		public string message = "Animal Succesfully Added";
    }
}
