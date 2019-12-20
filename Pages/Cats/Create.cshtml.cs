using System.Threading.Tasks;
using AnimalShelter.Data;
using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnimalShelter.Pages.Cats
{
    public class CreateModel : PageModel
    {
        private readonly ShelterContext _context;

        public CreateModel(ShelterContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty] public Cat Cat { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cats.Add(Cat);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}