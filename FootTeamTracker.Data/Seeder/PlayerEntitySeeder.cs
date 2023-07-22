using FootTeamTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootTeamTracker.Common.EntityValidationConstants;
using System.Xml.Linq;
using Player = FootTeamTracker.Data.Models.Player;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FootTeamTracker.Data.Seeder
{
	public class PlayerEntitySeeder 
	{

	
		public static HashSet<Player> GeneratePlayers()
		{
			var players = new HashSet<Player>();

			Player player;

			player = new Player()
			{
				Id = 1,
				Name = "Bukayo Saka",
				Position = Position.Striker,
				DateOfBirth = new DateTime(1995, 4, 15),
				TeamId = 1,
				GamesPlayed = 10,
				Goals = 5

			};
			players.Add(player);
			player = new Player()
			{
				Id = 2,
				Name = "Martin Odegaard",
				Position = Position.Midfielder,
				DateOfBirth = new DateTime(1998, 8, 21),
				TeamId = 1,
				GamesPlayed = 12,
				Goals = 2

			};
			players.Add(player);
			player = new Player()
			{
					Id = 3,
				Name= "Ben White",
				Position = Position.Defender,
				DateOfBirth = new DateTime(1993, 2, 10),
				TeamId = 1,
				GamesPlayed = 8,
				Goals = 0

			};
			players.Add(player);
			player = new Player()
			{
				Id = 4,
				Name = "Lionel Messi",
				Position = Position.Striker,
				DateOfBirth = new DateTime(1997, 11, 3),
				TeamId = 2,
				GamesPlayed = 15,
				Goals = 10,
				

			};
			players.Add(player);
			player = new Player()
			{
				Id = 5,
				Name = "David De Gea",
				Position = Position.GoalKeeper,
				DateOfBirth = new DateTime(1990, 6, 25),
				TeamId = 2,
				GamesPlayed = 5,
				Goals = 0

			};
			players.Add(player);
			player = new Player()
			{
				Id = 6,
				Name = "Cristiano Ronaldo",
				Position = Position.Striker,
				DateOfBirth = new DateTime(1985, 2, 5),
				TeamId = 2,
				GamesPlayed = 900,
				Goals = 800

			};
			players.Add(player);
			player = new Player()	
			{
				Id=7,
				Name = "Neymar Jr",
				Position = Position.Striker,
				DateOfBirth = new DateTime(1992, 2, 5),
				TeamId = 3,
				GamesPlayed = 500,
				Goals = 300,
				

			};
			players.Add(player);
			player = new Player()
			{
				Id = 8,
				Name = "Virgil van Dijk",
				Position = Position.Defender,
				DateOfBirth = new DateTime(1991, 7, 8),
				TeamId = 3,
				GamesPlayed = 300,
				Goals = 20

			};
			players.Add(player);
			player = new Player()
			{
				Id = 9,
				Name = "Kevin De Bruyne",
				Position = Position.Midfielder,
				DateOfBirth = new DateTime(1991, 6, 28),
				TeamId = 3,
				GamesPlayed = 400,
				Goals = 100

			};
			players.Add(player);

			player = new Player()
			{
				Id = 10,
				Name = "Kylian Mbappé",
				Position = Position.Striker,
				DateOfBirth = new DateTime(1998, 12, 20),
				TeamId = 4,
				GamesPlayed = 200,
				Goals = 150

			};
			players.Add(player);
			player  = new Player()
			{
				Id = 11,
				Name = "Robert Lewandowski",
				Position = Position.Striker,
				DateOfBirth = new DateTime(1988, 8, 21),
				TeamId = 4,
				GamesPlayed = 600,
				Goals = 400
				
			};

			players.Add(player);
			player = new Player()
			{
				Id = 12,
				Name = "Sergio Ramos",
				Position = Position.Defender,
				DateOfBirth = new DateTime(1986, 3, 30),
				TeamId = 4,
				GamesPlayed = 700,
				Goals = 100,
				
			};
			players.Add(player);

			player = new Player()
			{
				Id = 13,
				Name = "Kevin Mbappe",
				Position = Position.Midfielder,
				DateOfBirth = new DateTime(1991, 2, 26),
				TeamId = 5,
				GamesPlayed = 400,
				Goals = 50

			};
			players.Add(player);
			player = new Player()
			{
				Id = 14,
				Name = "Alisson Becker",
				Position = Position.GoalKeeper,
				DateOfBirth = new DateTime(1992, 10, 2),
				TeamId = 5,
				GamesPlayed = 300,
				Goals = 0

			};
			players.Add(player);
			player = new Player()
			{
				Id = 15,
				Name = "Mohamed Salah",
				Position = Position.Striker,
				DateOfBirth = new DateTime(1992, 6, 15),
				TeamId = 1,
				GamesPlayed = 400,
				Goals = 200

			};
			players.Add(player);

			return players;

		}
		

	}
}
