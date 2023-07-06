using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Models
{
	public class AppUser : IdentityUser<Guid>
	{
     

        public virtual ICollection<Team>? FavouriteTeams { get; set;} = new HashSet<Team>();

        public virtual ICollection<Player>? FavouritePlayers { get; set; } = new HashSet<Player>();

        public virtual ICollection<Match>? UpcomingGames { get; set; } = new HashSet<Match>();

        public virtual ICollection<TrainingSession>? TrainingSessionsToAttend { get; set; } = new HashSet<TrainingSession>();


		public virtual ICollection<Ticket>? TicketsReserved { get; set; } = new HashSet<Ticket>();


	}
}
