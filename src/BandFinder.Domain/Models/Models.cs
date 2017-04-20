using BandFinder.Domain.Models;
using System;
using System.Collections.Generic;


namespace BandFinder.Domain.Models
{
	public class Musician : BaseEntity
	{
		public string Name { get; set; }

		public string Bio { get; set; }

		public string Description { get; set; }

		public string Influences { get; set; }

		public DateTime? Founded { get; set; }

		public bool IsSearchingBand { get; set; }


		public virtual ICollection<Instrument> Instruments { get; set; }

		public virtual ICollection<Band> Bands { get; set; }
	}

	public class Band : BaseEntity
	{

		public string Name { get; set; }


		public string Description { get; set; }
		public string Influences { get; set; }

		public DateTime? Founded { get; set; }

		public bool IsSearchingMusician { get; set; }

		public virtual ICollection<Musician> Members { get; set; }
	}

	public class Instrument : BaseEntity
	{
		public string Name { get; set; }
		public virtual ICollection<Musician> Musicians { get; set; }
	}

	public class Genre : BaseEntity
	{
		public string Name { get; set; }
		public virtual ICollection<Style> Styles { get; set; }
	}

	public class Style : BaseEntity
	{
		public string Name { get; set; }
		public virtual Genre Genre { get; set; }
	}
}