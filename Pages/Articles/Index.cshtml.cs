using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

		public IList<Article> Article { get; set; } = default!;
		[BindProperty(SupportsGet = true)]
		public string? SearchString { get; set; }
		public SelectList? ReleaseDate { get; set; }
		[BindProperty(SupportsGet = true)]
		public string? ArticleReleaseDate { get; set; }
		public async Task OnGetAsync()
		{
			IQueryable<DateTime> genreQuery = from m in _context.Article
											  orderby m.ReleaseDate
											  select m.ReleaseDate;

			var articles = from a in _context.Article select a;
			if (!string.IsNullOrEmpty(SearchString))
			{
				articles = articles.Where(s => s.Title.Contains(SearchString));
			}
			if (!string.IsNullOrEmpty(ArticleReleaseDate))
			{
				articles = articles.Where(x => x.ReleaseDate == Convert.ToDateTime(ArticleReleaseDate));
			}

			Article = await articles.ToListAsync();
			ReleaseDate = new SelectList(await genreQuery.Distinct().ToListAsync());
		}


	}
}
