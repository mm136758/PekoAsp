using System;
using System.ComponentModel.DataAnnotations;

namespace PekoAsp.Models
{
	public class Article
	{
		public int ID { get; set; }
		public string Title { get; set; }

		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }
		public string Link { get; set; }
		public decimal Count { get; set; }
	}
}