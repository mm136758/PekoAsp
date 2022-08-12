using Microsoft.EntityFrameworkCore;

namespace PekoAsp.Data
{
	public class PekoAspContext : DbContext
	{
		public PekoAspContext(
			DbContextOptions<PekoAspContext> options)
			: base(options)
		{
		}

		public DbSet<PekoAsp.Models.Article> Article { get; set; }
	}
}