using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sfeclis_valentin_lab8.Data;
using sfeclis_valentin_lab8.Models;

namespace sfeclis_valentin_lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly sfeclis_valentin_lab8.Data.sfeclis_valentin_lab8Context _context;

        public IndexModel(sfeclis_valentin_lab8.Data.sfeclis_valentin_lab8Context context)
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
