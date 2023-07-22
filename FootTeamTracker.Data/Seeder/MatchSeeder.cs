using FootTeamTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FootTeamTracker.Data.Seeder
{
	public class MatchSeeder 
	{
		

		public static HashSet<Match> GenerateMatches()
		{
			var AllMatches = new HashSet<Match>();

			Match match;

			match = new Match()
			{
				Id = 13,
				AwayTeamName = "Barcelona",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(200),
				StadiumId = 1 ,
				

			};
			AllMatches.Add(match);
			match =  new Match()
			{
				Id = 14,
				AwayTeamName = "Manchester United",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(222),
				StadiumId = 1
			};
			AllMatches.Add(match);
			match = new Match()
			{
				Id = 15,
				AwayTeamName = "Barcelona",
				HomeTeamName = "Real Madrid",
				Date = DateTime.Now.AddDays(199),
				StadiumId = 1
			};
				AllMatches.Add(match);







			match = new Match()
			{
				Id = 1,
				AwayTeamName = "Barcelona",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(233),
				StadiumId = 2
			};
			AllMatches.Add(match);
			match    =new Match()
			{
				Id = 2,
				AwayTeamName = "PSG",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(235),
				StadiumId = 2
			};
			AllMatches.Add(match);
			match = new Match()
			{
				Id = 3,
				AwayTeamName = "Barcelona",
				HomeTeamName = "PSG",
				Date = DateTime.Now.AddDays(236),
				StadiumId = 2
			};
			AllMatches.Add(match);


			match = new Match()
			{
				Id = 4,
				AwayTeamName = "Real Madrid",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(411),
				StadiumId = 3
			};
			AllMatches.Add(match);
			match = new Match()
			{


				Id = 5,
				AwayTeamName = "PSG",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(300),
				StadiumId = 3
			};
			AllMatches.Add(match);
			match = new Match()
			{
				Id = 6,
				AwayTeamName = "Real Madrid",
				HomeTeamName = "Manchester United",
				Date = DateTime.Now.AddDays(400),
				StadiumId = 3
			};
			AllMatches.Add(match);



			match = new Match()
			{
				Id = 7,
				AwayTeamName = "Barcelona",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(81),
				StadiumId = 4
			};
			AllMatches.Add(match);
			match = new Match()
			{
				Id = 8,
				AwayTeamName = "PSG",
				HomeTeamName = "Manchester United",
				Date = DateTime.Now.AddDays(90),
				StadiumId = 4
			};
			AllMatches.Add(match);
			match = new Match()
			{
				Id = 9,
				AwayTeamName = "Barcelona",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(500),
				StadiumId = 4
			};
			AllMatches.Add(match);


			match = new Match()
			{
				Id = 10,
				AwayTeamName = "Barcelona",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(191),
				StadiumId = 5
			};
			AllMatches.Add(match);
			match = new Match()
			{
				Id = 11,
				AwayTeamName = "PSG",
				HomeTeamName = "Arsenal",
				Date = DateTime.Now.AddDays(221),
				StadiumId = 5
			};
			AllMatches.Add(match);
			match = new Match()
			{
				Id = 12,
				AwayTeamName = "Barcelona",
				HomeTeamName = "PSG",
				Date = DateTime.Now.AddDays(97),
				StadiumId = 5
			};
			AllMatches.Add(match);

			return AllMatches;
		}
	}
}
