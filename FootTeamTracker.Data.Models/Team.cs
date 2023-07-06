using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FootTeamTracker.Data.Models
{
	using static FootTeamTracker.Common.EntityValidationConstants.Team;

	public class Team
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		[MinLength(NameMinLength)]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(LogoMaxLength)]
		[MinLength(LogoMinLength)]
		public string Logo { get; set; } = null!;

		[Required]
		public int StadiumId { get; set; }

		[Required]
		[ForeignKey(nameof(StadiumId))]
		public virtual Stadium Stadium { get; set; } = null!;
		public ICollection<Player> Players { get; set; } = new HashSet<Player>();

		[Required]
		public ICollection<TrainingSession> TrainingSessions { get; set; } = new HashSet<TrainingSession>();



		
		public virtual ICollection<Trophy>? Trophys { get; set; } = new HashSet<Trophy>();



		public int? NewsId { get; set; }

		[ForeignKey(nameof(NewsId))]
		public virtual News? News { get; set; }

	

		public virtual ICollection<AppUser> AppUsers { get; set; } = new HashSet<AppUser>();


	}

}