using System.Threading.Tasks;
using AnimalShelter.Data;
using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Pages.Cats
{
    public class DetailsModel : PageModel
    {
        private readonly ShelterContext _context;

        public DetailsModel(ShelterContext context)
        {
            _context = context;
        }

        public Cat Cat { get; set; }

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
    }
}