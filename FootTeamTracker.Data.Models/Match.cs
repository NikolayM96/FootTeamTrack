using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Models
{


	public class Match
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public DateTime Date { get; set; }



		[Required]
		public string HomeTeamName { get; set; } = null!;


		[Required]
		public string AwayTeamName { get; set; } = null!;

	

		[Required]
		public string StadiumName { get; set; } = null!;





		


		public virtual ICollection<AppUser> AppUsers { get; set; } = new HashSet<AppUser>();




	}
}
