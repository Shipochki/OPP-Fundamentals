using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OPP_Fundamentals_Class_Diagram
{
	public class User
	{
		public int Id { get; set; }

		public string FirstName { get; set; } = null!; 

		public string LastName { get; set; } = null!;

		public string PhoneNumber { get; set; } = null!;

		public string City { get; set; } = null!;

		public string Email { get; set; } = null!;

		public string PasswordHashed { get; set; } = null!;

		public string? PictureLink { get; set; }

		public List<Review> Reviews { get; set; } = new List<Review>();

		public List<Message> Messages { get; set; } = new List<Message>();

		public List<UserGroup> UsersGroups { get; set; } = new List<UserGroup>();

		public DateTime CreatedOn { get; set; }

		public DateTime UpdatedOn { get; set; }

		public DateTime DeletedOn { get; set; }

		public bool IsActive { get; set; }

		public string Country { get; set; } = null!;
	}
}