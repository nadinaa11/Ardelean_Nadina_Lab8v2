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
    public class IndexModel : PageModel
    {
        private readonly Ardelean_Nadina_Lab8v2.Data.Ardelean_Nadina_Lab8v2Context _context;

        public IndexModel(Ardelean_Nadina_Lab8v2.Data.Ardelean_Nadina_Lab8v2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
