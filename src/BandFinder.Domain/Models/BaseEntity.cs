using System;

namespace BandFinder.Domain.Models
{
	public class BaseEntity
	{
		public object Id { get; set; }


		public DateTime? CreatedAt { get; set; }
		public DateTime? EditedAt { get; set; }
	}

	public class BaseEntityAuthoring : BaseEntity
	{
		public object CreatedBt { get; set; }
		public object EditedBy { get; set; }
	}

}
