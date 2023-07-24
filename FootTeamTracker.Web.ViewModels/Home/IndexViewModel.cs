using FootTeamTracker.Data.Models;
using FootTeamTracker.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Web.ViewModels.Home
{
	public class IndexViewModel : IMapFrom<Team>
	{
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

		public string Logo { get; set; } = null!;


	}
}
