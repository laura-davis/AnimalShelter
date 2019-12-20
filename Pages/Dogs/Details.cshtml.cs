using System.Threading.Tasks;
using AnimalShelter.Data;
using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Pages.Dogs
{
    public class DetailsModel : PageModel
    {
        private readonly ShelterContext _context;

        public DetailsModel(ShelterContext context)
        {
            _context = context;
        }

        public Dog Dog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dog = await _context.Dogs
                .Include(d => d.Adoptions)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.DogID == id);

            if (Dog == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}