using FootTeamTracker.Data;
using FootTeamTracker.Services.Models.Interfaces;
using FootTeamTracker.Web.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using FootTeamTracker.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Services.Data
{
	public class TeamService : ITeamService
	{
		private readonly FootTeamTrackerDbContext dbContext;

		public TeamService(FootTeamTrackerDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public async Task<IEnumerable<IndexViewModel>> TeamsByAlphabeticalAsync()
		{
			IEnumerable<IndexViewModel> teamsByName = await dbContext
				.Teams
				.OrderBy(t => t.Name)
				.Take(4)
				.To<IndexViewModel>()
				.ToArrayAsync();


			return teamsByName;
		}
	}
}
