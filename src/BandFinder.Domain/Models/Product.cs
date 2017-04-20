using System.Collections.Generic;

namespace BandFinder.Domain.Models
{
	public class Product : BaseEntity
	{
		public int ProductId { get; set; }
		
		public string Code { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public string Cover { get; set; }

		public virtual ProductCategory Category { get; set; }

		public ICollection<string> Photos { get; set; }

	}
}
