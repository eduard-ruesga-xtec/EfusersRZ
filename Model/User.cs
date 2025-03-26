using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfusersRz.Model
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		public string? Name { get; set; }
		public string? Surname { get; set; }

		public int AddressId { get; set; }

		[ForeignKey("AddressId")]
		public Address Address { get; set; }
	}
}
