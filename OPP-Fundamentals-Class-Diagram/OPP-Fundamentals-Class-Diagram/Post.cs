﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Fundamentals_Class_Diagram
{
	public class Post
	{
		public int Id { get; set; }

		public string FromDestination { get; set; } = null!;

		public string ToDestination { get; set; } = null!;

		public string Description { get; set; } = null!;

		public decimal PriceForSeat { get; set; }

		public bool SpaceForBaggage { get; set; }

		public int CountSeats { get; set; }

		public bool IsCompleted { get; set; }

		public DateTime DateAndTime { get; set; }

		public int CreatorId { get; set; }

		public Driver Driver { get; set; } = null!;

		public int GroupId { get; set; }

		public Group Group { get; set; } = null!;

		public DateTime CreatedOn { get; set; }

		public DateTime UpdatedOn { get; set; }

		public DateTime DeletedOn { get; set; }

		public bool IsActive { get; set; }
	}
}
