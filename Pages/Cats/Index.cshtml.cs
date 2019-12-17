using System.Collections.Generic;
using System.Threading.Tasks;
using DogShelter.Data;
using DogShelter.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DogShelter.Pages.Cats
{
    public class IndexModel : PageModel
    {
        private readonly ShelterContext _context;

        public IndexModel(ShelterContext context)
        {
            _context = context;
        }

        public IList<Cat> Cat { get; set; }

        public async Task OnGetAsync()
        {
            Cat = await _context.Cats.ToListAsync();
        }
    }
}