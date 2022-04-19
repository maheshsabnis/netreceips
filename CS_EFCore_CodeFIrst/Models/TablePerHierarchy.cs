using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EFCore_CodeFIrst.Models
{
	public class ProductionUnit
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int ReleaseYear { get; set; }
	}

	public class Movies : ProductionUnit
	{
		public string Category { get; set; }
		public int Duration { get; set; }
		public int Collection { get; set; }
	}

	public class WebSeries : ProductionUnit
	{
		public int NoOfSeasons { get; set; }
		public int EpisodsPerSeason { get; set; }
	}
}
