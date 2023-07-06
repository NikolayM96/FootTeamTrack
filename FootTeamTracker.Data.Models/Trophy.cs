using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Models
{
	using static FootTeamTracker.Common.EntityValidationConstants.Trophy;
	public class Trophy
	{

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		[MinLength(NameMinLength)]
		public string Name { get; set; } = null!;

		[Required]
		public DateTime Year { get; set; }

		[Required]
		[MaxLength(DescriptionMaxLength)]
		[MinLength(DescriptionMinLength)]
		public string Description { get; set; } = null!;


		[Required]
		public int TeamId { get; set; }

		[Required]
		[ForeignKey(nameof(TeamId))]
		[InverseProperty("Trophys")]
		public virtual Team Team { get; set; } = null!;





	}
}
