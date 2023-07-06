using FootTeamTracker.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FootTeamTracker.Data
{
	public class FootTeamTrackerDbContext : IdentityDbContext<AppUser , IdentityRole<Guid>, Guid>
	{
		public FootTeamTrackerDbContext(DbContextOptions<FootTeamTrackerDbContext> options)
			: base(options)
		{

		}

	

	

		public DbSet<Injury> Injuries { get; set; }

	

		public DbSet<Match> Matches { get; set; }

		public DbSet<News> News { get; set; }

		public DbSet<Player> Players { get; set; }


		public DbSet<Stadium> Stadiums { get; set; }

		public DbSet<Team> Teams { get; set; }

		public DbSet<TrainingSession> TrainingSessions { get; set; }

		public DbSet<Trophy> Trophies { get; set; }

		public DbSet<Ticket> Tickets { get; set; }

		public DbSet<AppUser> AppUsers { get; set; }



		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}


	}
}