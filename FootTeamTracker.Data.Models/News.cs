using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Models
{
	using static FootTeamTracker.Common.EntityValidationConstants.News;

	public class News
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(TitleMaxLength)]
		[MinLength(TitleMinLength)]
		public string Title { get; set; } = null!;

		[Required]
		[MaxLength(ContentMaxLength)]
		[MinLength(ContentMinLength)]
		public string Content { get; set; } = null!;
		public DateTime Date { get; set; }

		[Required]
		[MaxLength(ImageMaxLength)]
		[MinLength(ImageMinLength)]
		public string ImageUrl { get; set; } = null!;

		[Required]
		public int TeamId { get; set; }

		
		[ForeignKey(nameof(TeamId))]
		public virtual Team Team { get; set; } = null!;

		
	}
}
