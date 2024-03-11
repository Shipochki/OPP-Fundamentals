using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Fundamentals_Class_Diagram
{
	public class Driver
	{
		public int Id { get; set; }

		public int UserId { get; set; }

		public User User { get; set; } = null!;

		public bool IsVerified { get; set; }

		public List<Post> Posts { get; set; } = new List<Post>();

		public int VehicleId { get; set; }
		public Vehicle Vehicle { get; set; } = null!;
	}
}
