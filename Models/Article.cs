using System;
using System.ComponentModel.DataAnnotations;

namespace PekoAsp.Models
{
	public class Article
	{
		public int ID { get; set; }
		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Title { get; set; }

		[Display(Name = "ReleaseDate")]
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
		[Required]
		public DateTime ReleaseDate { get; set; }
		public string Link { get; set; }
		public decimal Count { get; set; }
		[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
		[StringLength(30)]
		public string Category { get; set; }
	}
}