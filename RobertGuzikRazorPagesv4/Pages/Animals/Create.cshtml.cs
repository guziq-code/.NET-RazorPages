using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RobertGuzikRazorPagesv4.Models;

namespace RobertGuzikRazorPagesv4.Pages.Animals
{
    public class CreateModel : PageModel
    {
        AnimalContext AnimalContext = new AnimalContext();
        public Animal animal { get; set; }

        [TempData]
        public string message{get; set;}

        public void OnGet(){ 
        }    
        
        public IActionResult OnPost(Animal animal)
        {
            AnimalContext.Animals.Add(animal);
            AnimalContext.SaveChanges();
            message = "Animal Succesfully Added";
            return RedirectToPage("Index");

        }
    }
}
