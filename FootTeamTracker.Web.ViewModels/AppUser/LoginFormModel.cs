using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Web.ViewModels.AppUser
{
	using System.ComponentModel.DataAnnotations;

	public class LoginFormModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; } = null!;

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; } = null!;

		[Display(Name = "Remember me?")]
		public bool RememberMe { get; set; }

		public string? ReturnUrl { get; set; }
	}
}
