using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OPP_Fundamentals_Class_Diagram
{
	public class Vehicle
	{
		public int Id { get; set; }

		public string Model { get; set; } = null!;

		public int Year { get; set; }

		public Fuel Fuel { get; set; }

		public int SeatCount { get; set; }

		public string Brand { get; set; } = null!;

		public string? PictureLink { get; set; }

		public bool ACSistem { get; set; }
	}
}