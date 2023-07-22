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
	public class TrophySeeder 
	{
	

		public static HashSet<Trophy> GenerateTrophies()
		{
			return new HashSet<Trophy>()
			{
					new Trophy()
								{
									Id = 1,
									Name = "FIFA World Cup",
									Year = new DateTime(2018, 1, 1),
									TeamId = 1,
									Description = "The FIFA World Cup is the most prestigious international football tournament held every four years."
								},
					new Trophy()
								{

									Id = 2,
									Name = "UEFA Champions League",
									Year = new DateTime(2020, 1, 1),
									TeamId = 2,
									Description = "The UEFA Champions League is an annual club football competition organized by the Union of European Football Associations (UEFA)."
								},
						new Trophy()
								{

									Id = 3,
									Name = "FIFA Club World Cup",
									Year = new DateTime(2020, 1, 1),
									TeamId = 3,
									Description = "The FIFA Club World Cup is an international men's association football competition organized by the Fédération Internationale de Football Association (FIFA)."
								},
								new Trophy()
								{

									Id = 4,
									Name = "UEFA European Championship",
									Year = new DateTime(2021, 1, 1),
									TeamId = 4,
									Description = "The UEFA European Championship is the primary association football competition contested by the senior men's national teams of the members of UEFA."
								},
					new Trophy()
								{

									Id = 5,
									Name = "Premier League",
									Year = new DateTime(2021, 1, 1),
									TeamId = 5,
									Description = "The Premier League is the top professional football league in England."


								}
			};
		}
	}
}
