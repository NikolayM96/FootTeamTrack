using FootTeamTracker.Data.Models;
using FootTeamTracker.Data.Seeder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace FootTeamTracker.Data
{
	public class FootTeamTrackerDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
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
			Assembly configAssembly = Assembly.GetAssembly(typeof(FootTeamTrackerDbContext)) ??
									  Assembly.GetExecutingAssembly();
			builder.ApplyConfigurationsFromAssembly(configAssembly);

			builder.Entity<Stadium>().HasData(StadiumEntitySeeder.GenerateStadiums());
			builder.Entity<Match>().HasData(MatchSeeder.GenerateMatches());
			builder.Entity<Ticket>().HasData(TicketSeeder.GenerateTickets());
			builder.Entity<Team>().HasData(TeamEntitySeeder.GenerateTeams());
			builder.Entity<Player>().HasData(PlayerEntitySeeder.GeneratePlayers());
			builder.Entity<Injury>().HasData(InjuryEntitySeeder.GenerateInjuries());
			builder.Entity<Trophy>().HasData(TrophySeeder.GenerateTrophies());
			builder.Entity<TrainingSession>().HasData(TrainingSessionsEntitySeeder.GenerateSessions());
			builder.Entity<News>().HasData(NewsSeeder.GenerateNews());





			base.OnModelCreating(builder);



		}
	}

}