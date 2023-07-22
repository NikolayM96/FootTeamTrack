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
	public class NewsSeeder 
	{
	

		public static HashSet<News> GenerateNews()
		{
			var news = new HashSet<News>();

			News news1;

			news1 = new News
			{
				Id = 1 ,
				Title = "Team Wins Championship",
				Content = "The team secured a victory in the championship match.",
				Date = new DateTime(2021, 1, 1),
				ImageUrl = "Champions.jpg",
				TeamId =1

			};
			news.Add(news1);
			new News
			{

				Id = 2 ,
				Title = "New Signing Announcement",
				Content = "The team officially announced the signing of a new player.",
				Date = new DateTime(2021, 2, 1),
				ImageUrl = "New-Signing.jpeg",
				TeamId = 2
			};
			news.Add(news1);
			new News
			{
				Id = 3,
				Title = "Manager's Contract Extension",
				Content = "The team's manager has signed a contract extension.",
				Date = new DateTime(2021, 3, 1),
				ImageUrl = "PepGuardiolaManCity.jpg",
				TeamId= 3
			};
			news.Add(news1);
			new News
			{
				Id = 4,
				Title = "Upcoming Friendly Match",
				Content = "The team will play a friendly match against a strong opponent.",
				Date = new DateTime(2021, 4, 1),
				ImageUrl = "Friendly-Match.jpg",
				TeamId = 4
			};
			news.Add(news1);
			new News
			{
				Id = 5,
				Title = "Community Service Initiative",
				Content = "The team participated in a community service initiative to give back to the local community.",
				Date = new DateTime(2021, 5, 1),
				ImageUrl = "Community.png",
				TeamId = 5

			};
			news.Add(news1);

			return news;

		}
	}
}
