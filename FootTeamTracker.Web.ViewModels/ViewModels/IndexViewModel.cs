using FootTeamTracker.Data.Models;
using FootTeamTracker.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Web.ViewModels.ViewModels
{
	public class IndexViewModel : IMapFrom<Team>
	{
		public string Name { get; set; } = null!;


	}
}
