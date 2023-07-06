using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Models
{
	using static FootTeamTracker.Common.EntityValidationConstants.Stadium;

	public class Stadium
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		[MinLength(NameMinLength)]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(LocationMaxLength)]
		[MinLength(LocationMaxLength)]
		public string Location { get; set; } = null!;

		[Required]
		[Range(0 , int.MaxValue)]
		public int SeatingCapacity { get; set; }




		
	}
}
