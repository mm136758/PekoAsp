using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PekoAsp.Data;
using PekoAsp.Models;

namespace PekoAsp.Pages_Articles
{
    public class IndexModel : PageModel
    {
        private readonly PekoAsp.Data.PekoAspContext _context;

        public IndexModel(PekoAsp.Data.PekoAspContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Article != null)
            {
                Article = await _context.Article.ToListAsync();
            }
        }
    }
}
