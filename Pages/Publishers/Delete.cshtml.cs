using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ardelean_Nadina_Lab8v2.Data;
using Ardelean_Nadina_Lab8v2.Models;

namespace Ardelean_Nadina_Lab8v2.Pages.Publishers
{
    public class DeleteModel : PageModel
    {
        private readonly Ardelean_Nadina_Lab8v2.Data.Ardelean_Nadina_Lab8v2Context _context;

        public DeleteModel(Ardelean_Nadina_Lab8v2.Data.Ardelean_Nadina_Lab8v2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FindAsync(id);

            if (Publisher != null)
            {
                _context.Publisher.Remove(Publisher);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
