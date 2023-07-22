using FootTeamTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Match = FootTeamTracker.Data.Models.Match;

namespace FootTeamTracker.Data.Seeder
{
	public class StadiumEntitySeeder 
	{
	

		public static  HashSet<Stadium> GenerateStadiums()
		{
			var stadiums = new HashSet<Stadium>();

			Stadium stadium1;
			Stadium stadium2;
			Stadium stadium3;
			Stadium stadium4;
			Stadium stadium5;


			stadium1 = new Stadium()
			{
				Id = 1,
				Name = "Wembley Stadium",
				Location = "London, England",
				SeatingCapacity = 90000,
				 

			};
			stadiums.Add(stadium1);
			stadium2 = new Stadium()
			{
				Id = 2,
					Name = "Camp Nou",
				Location = "Barcelona, Spain",
				SeatingCapacity = 99354 ,
				
				
			};
			
			stadiums.Add(stadium2);

			stadium3 = new Stadium()
			{
				Id = 3,
				Name = "Allianz Arena",
				Location = "Munich, Germany",
				SeatingCapacity = 75000 ,
		
				
				
			};
			
			stadiums.Add(stadium3);
			stadium4 = new Stadium()
			{
				Id = 4,
				Name = "Old Trafford",
				Location = "Manchester, England",
				SeatingCapacity = 74609,
			
			};
			
		
			stadiums.Add(stadium4);
			stadium5 = new Stadium()
			{
				Id = 5,
				Name = "San Siro",
				Location = "Milan, Italy",
				SeatingCapacity = 80018,
			
			};
			
			stadiums.Add(stadium5);

			return stadiums;
		}
	}
}
