﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OPP_Fundamentals_Class_Diagram
{
	public class Admin
	{
		public int Id { get; set; }

		public int UserId { get; set; }

		public User User { get; set; } = null!;
	}
}