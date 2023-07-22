using FootTeamTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootTeamTracker.Common.EntityValidationConstants;

namespace FootTeamTracker.Data.Seeder
{
	public class TicketSeeder 
	{
	

		public static HashSet<Ticket> GenerateTickets()
		{
			return new HashSet<Ticket>()
			{
				new Ticket()
				{
					StadiumId = 1


				},
			new Ticket()
				{
					StadiumId = 1


				},
			new Ticket()
				{
					StadiumId = 1


				},
			new Ticket()
				{
					StadiumId = 1


				},
			new Ticket()
				{
					StadiumId = 2


				},
			new Ticket()
				{
					StadiumId = 2


				},
			new Ticket()
				{
					StadiumId = 2


				},
			new Ticket()
				{
					StadiumId = 2


				},
			new Ticket()
				{
					StadiumId = 3


				},
			new Ticket()
				{
					StadiumId = 3


				},
			new Ticket()
				{
					StadiumId = 3


				},
			new Ticket()
				{
					StadiumId = 3


				},
			new Ticket()
				{
					StadiumId = 4


				},
			new Ticket()
				{
					StadiumId = 4


				},
			new Ticket()
				{
					StadiumId = 4


				},
			new Ticket()
				{
					StadiumId = 5


				},
			new Ticket()
				{
					StadiumId = 5


				},
			new Ticket()
				{
					StadiumId = 5


				},
			};
		}
	}
}
