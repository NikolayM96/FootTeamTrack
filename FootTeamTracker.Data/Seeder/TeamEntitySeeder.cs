using FootTeamTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Seeder
{
	public class TeamEntitySeeder 
	{

		public static HashSet<Team> GenerateTeams()
		{
			HashSet<Team> teams = new HashSet<Team>();

			Team team;

			//Arsenal
			team = new Team()
			{
				Id = 1,	
				Name = "Arsenal",
				Logo = "arsenal_logo_PNG1.png",
				StadiumId = 1,	


			};
			teams.Add(team);

			//Barcelona
			team = new Team()
			{
				Id = 2,
				Name = "Barcelona",
				Logo = "Barcelona-Logo-PNG1.png",
				StadiumId = 2,
				 
			};
			teams.Add(team);
			//PSG
			team = new Team()
			{
				Id = 3,
				Name = "PSG",
				Logo = "PSG-Logo-PNG1.png",
				StadiumId = 3,
			};
			teams.Add(team);
			//Real Madrid
			team = new Team()
			{
				Id = 4,
				Name = "Real Madrid",
				Logo = "Real_Madrid_logo_PNG5.png",
				StadiumId = 4,
				

			};
			teams.Add(team);
			//Manchester United
			team = new Team()
			{
				Id = 5,
				Name = "Manchester United",
				Logo = "manchester_united_logo_PNG3.png",
				StadiumId = 5,
				
			};
			teams.Add(team);

			return teams;
		}
	}
}
