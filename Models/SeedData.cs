using Microsoft.EntityFrameworkCore;
using PekoAsp.Data;

namespace PekoAsp.Models
{
	public static class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new PekoAspContext(
				serviceProvider.GetRequiredService<
					DbContextOptions<PekoAspContext>>()))
			{
				if (context == null || context.Article == null)
				{
					throw new ArgumentNullException("Null PekoAspContext");
				}

				// Look for any Articles.
				if (context.Article.Any())
				{
					return;   // DB has been seeded
				}

				context.Article.AddRange(
					new Article
					{
						Title = "禮拜一吃牛肉飯",
						ReleaseDate = DateTime.Parse("2022-8-13"),
						Link = "sukiya",
						Count = 200
					},

					new Article
					{
						Title = "禮拜二吃泡麵",
						ReleaseDate = DateTime.Parse("2022-8-13"),
						Link = "idon't know",
						Count = 200
					},

					new Article
					{
						Title = "禮拜3吃泡麵",
						ReleaseDate = DateTime.Parse("2022-8-13"),
						Link = "idon't know",
						Count = 200
					},

					new Article
					{
						Title = "禮拜4吃泡麵",
						ReleaseDate = DateTime.Parse("2022-8-13"),
						Link = "idon't know",
						Count = 200
					}
				);
				context.SaveChanges();
			}
		}
	}
}