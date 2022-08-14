using System;
using System.ComponentModel.DataAnnotations;

namespace PekoAsp.Models
{
	public class Article
	{
		public int ID { get; set; }
		public string Title { get; set; }

		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
		public DateTime ReleaseDate { get; set; }
		public string Link { get; set; }
		public decimal Count { get; set; }
	}
}