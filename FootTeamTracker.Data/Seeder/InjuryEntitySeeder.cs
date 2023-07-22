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
	public class InjuryEntitySeeder 
	{
		

		public static HashSet<Injury> GenerateInjuries()
		{
			var injuries = new HashSet<Injury>();
			Injury injury;

			injury = new Injury()
			{
				Id = 1 , 
				Type = "Sprained Ankle",
				Date = new DateTime(2021, 1, 1),
				ExpectedRecoveryTime = TimeSpan.FromMinutes(20.999999),
				PlayerId = 1
			};
			injuries.Add(injury);

			injury = new Injury()
			{
				Id = 2,
				Type = "Muscle Strain",
				Date = new DateTime(2021, 2, 1),
				ExpectedRecoveryTime = TimeSpan.FromMinutes(15.999999),
				PlayerId = 2

			};
			injuries.Add(injury);
			injury = new Injury()
			{
				Id = 3,
				Type = "Hamstring Injury",
				Date = new DateTime(2021, 3, 1),
				ExpectedRecoveryTime = TimeSpan.FromMinutes(13.999999),
				PlayerId = 3
			};
			injuries.Add(injury);
			injury = new Injury()
			{

				Id = 4,
				Type = "Knee Ligament Tear",
				Date = new DateTime(2021, 4, 1),
				ExpectedRecoveryTime = TimeSpan.FromMinutes(11.999999),
				PlayerId = 4
			};
			injuries.Add(injury);
			injury = new Injury()
			{
				Id = 5,
				Type = "Concussion",
				Date = new DateTime(2021, 5, 1),
				ExpectedRecoveryTime = TimeSpan.FromMinutes(3.999999),
				PlayerId = 5
			};
			injuries.Add(injury);

			return injuries;
		}
	}
}
