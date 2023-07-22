using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Models
{
	using static FootTeamTracker.Common.EntityValidationConstants.Injury;
	public class Injury
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(TypeMaxLength)]
		[MinLength(TypeMinLength)]
		public string Type { get; set; } = null!;

		[Required]
		public DateTime Date { get; set; }
		public TimeSpan ExpectedRecoveryTime { get; set; }

		[Required]
		public int PlayerId { get; set; }

	
		[ForeignKey(nameof(PlayerId))]
		public Player Player { get; set; } = null!;
	}
}
