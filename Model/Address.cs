using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfusersRz.Model
{
	public class Address
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string? Street { get; set; }
		public string? City { get; set; }

		[MaxLength (8)]
		public string? PostalCode { get; set; }

		public User User { get; set; }

	}
}
