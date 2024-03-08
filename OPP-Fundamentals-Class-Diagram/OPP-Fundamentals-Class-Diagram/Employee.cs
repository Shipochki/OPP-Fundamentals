using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OPP_Fundamentals_Class_Diagram
{
	public class Employee
	{
		public int Id { get; set; }

		public User User { get; set; } = null!;

		public int UserId { get; set; }
	}
}