
namespace Shop.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;

	public class Product
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
		public string Name { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		[DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
		public decimal Price { get; set; }

		[Display(Name = "Image")]
		public string ImageUrl { get; set; }

		[Display(Name = "Last Purchase")]
		public DateTime? LastPurchase { get; set; }

		[Display(Name = "Last Sale")]
		public DateTime? LastSale { get; set; }

		[Display(Name = "Is Availabe?")]
		public bool IsAvailabe { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
		public double Stock { get; set; }
	}
}