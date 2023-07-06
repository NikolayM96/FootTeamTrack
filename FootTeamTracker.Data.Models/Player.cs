using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Models
{
	using static FootTeamTracker.Common.EntityValidationConstants.Player;

	public class Player
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		[MinLength(NameMinLength)]
		public string Name { get; set; } = null!;

		[Required]
		public Position Position { get; set; }

		[Required]
		public DateTime DateOfBirth { get; set; }

		[Required]
		public int TeamId { get; set; }

		[Required]
		[ForeignKey(nameof(TeamId))]
		public Team Team { get; set; } = null!;

		[Required]
		public int GamesPlayed { get; set; }

		[Required]
		public int Goals{ get; set; }

		public int InjuryId { get; set; }
		
		public virtual Injury? Injury { get; set; }



		public virtual ICollection<AppUser> AppUsers { get; set; } = new HashSet<AppUser>();
	}
}
