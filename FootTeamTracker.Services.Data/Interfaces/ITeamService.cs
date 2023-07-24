using FootTeamTracker.Web.ViewModels.Home;	
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Services.Models.Interfaces
{
	public interface ITeamService
	{
		//Task<AllTeamsDisplayed> AllAsync(AllTeamsQueryModel queryModel);

		Task<IEnumerable<IndexViewModel>> TeamsByAlphabeticalAsync();
	}
}
