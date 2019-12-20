using System.Threading.Tasks;
using AnimalShelter.Data;
using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Pages.Dogs
{
    public class DeleteModel : PageModel
    {
        private readonly ShelterContext _context;

        public DeleteModel(ShelterContext context)
        {
            _context = context;
        }

        [BindProperty] public Dog Dog { get; set; }
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dog = await _context.Dogs
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.DogID == id);

            if (Dog == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ErrorMessage = "Delete failed. Try again";
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs.FindAsync(id);

            if (dog == null)
            {
                return NotFound();
            }

            try
            {
                _context.Dogs.Remove(dog);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            catch (DbUpdateException)
            {
                return RedirectToAction("./Delete",
                    new {id, saveChangesError = true});
            }
        }
    }
}