using System.Threading.Tasks;
using DogShelter.Data;
using DogShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DogShelter.Pages.Dogs
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
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Dog == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}