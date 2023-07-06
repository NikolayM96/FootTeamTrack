using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Models
{
	using static FootTeamTracker.Common.EntityValidationConstants.TrainingSession;
	public class TrainingSession
	{

		[Key]
		public int Id { get; set; }

		[Required]
		public DateTime Date { get; set; }

		[Required]
		public TimeSpan Time { get; set; }

		[Required]
		[MaxLength(LocationMaxLength)]
		[MinLength(LocationMinLength)]
		public string Location { get; set; } = null!;

		[Required]
		[MaxLength(ObjectivesMaxLength)]
		[MinLength(ObjectivesMinLength)]
		public string Objectives { get; set; } = null!;

		[Required]
		public int TeamId { get; set; }

		[Required]
		[ForeignKey(nameof(TeamId))]
		public virtual Team Team { get; set; } = null!;

		public virtual ICollection<AppUser> AppUsers { get; set; } = new HashSet<AppUser>();
	}
}
