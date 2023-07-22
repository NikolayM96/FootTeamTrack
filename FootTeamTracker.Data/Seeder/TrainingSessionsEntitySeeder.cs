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
	public class TrainingSessionsEntitySeeder 
	{
	

		public static HashSet<TrainingSession> GenerateSessions()
		{
			var trainSessions = new HashSet<TrainingSession>();

			TrainingSession session;

			session = new TrainingSession()
			{
				Id = 1,
				Date = new DateTime(2021, 1, 1),
				Time = new TimeSpan(8, 0, 0),
				Location = "Training Ground 1",
				Objectives = "Improve passing and teamwork",
				TeamId = 1
				
			};
			trainSessions.Add(session);
		session =	new TrainingSession()
			{

				Id = 2,
				Date = new DateTime(2021, 2, 1),
				Time = new TimeSpan(4, 0, 0),
				Location = "Training Ground 2",
				Objectives = "Focus on defensive drills",
				TeamId = 2

			};
			trainSessions.Add(session);
		session =	new TrainingSession()
			{


				Id = 3,
				Date = new DateTime(2021, 3, 1),
				Time = new TimeSpan(6, 30, 0),
				Location = "Training Ground 3",
				Objectives = "Improve fitness and conditioning",
				TeamId = 3

			};
			trainSessions.Add(session);
			session = new TrainingSession()
			{
				Id= 4,
				Date = new DateTime(2021, 4, 1),
				Time = new TimeSpan(6, 20, 15),
				Location = "Training Ground 4",
				Objectives = "Work on set-piece routines",
				TeamId = 4

			};
			trainSessions.Add(session);
			session = new TrainingSession()
			{
				Id = 5,
				Date = new DateTime(2021, 5, 1),
				Time = new TimeSpan(1, 55, 22),
				Location = "Training Ground 5",
				Objectives = "Improve shooting accuracy",
				TeamId = 5

			};
			trainSessions.Add(session);

			return trainSessions;
		}
	}
}
