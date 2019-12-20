using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Data;
using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Pages.Cats
{
    public class EditModel : PageModel
    {
        private readonly ShelterContext _context;

        public EditModel(ShelterContext context)
        {
            _context = context;
        }

        [BindProperty] public Cat Cat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cat = await _context.Cats.FirstOrDefaultAsync(m => m.CatID == id);

            if (Cat == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CatExists(Cat.CatID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CatExists(int id)
        {
            return _context.Cats.Any(e => e.CatID == id);
        }
    }
}