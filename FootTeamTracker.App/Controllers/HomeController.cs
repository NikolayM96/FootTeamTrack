using FootTeamTracker.Services.Models.Interfaces;
using FootTeamTracker.Web.ViewModels;
using FootTeamTracker.Web.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FootTeamTracker.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ITeamService teamService;

		public HomeController(ITeamService teamService)
		{
			this.teamService = teamService;
		}

		public async Task<IActionResult> Index()
		{
			IEnumerable<IndexViewModel> viewModel =
				await teamService.TeamsByAlphabeticalAsync();

			return View(viewModel);
		}

		public IActionResult Error(int statusCode)
		{
			if (statusCode == 400 || statusCode == 404)
			{
				return View("Error404");
			}

			if (statusCode == 401)
			{
				return View("Error401");
			}

			return View();
		}
	}
}