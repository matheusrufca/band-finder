using System.Collections.Generic;

namespace BandFinder.Domain.Models
{
	public class ProductCategory : BaseEntity
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public virtual ICollection<Product> Products { get; set; }

		public virtual ProductCategory ParentCategory { get; set; }

		public virtual ICollection<ProductCategory> ChildrenCategories { get; set; }
	}
}
