using FootTeamTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Configurations
{
	//public class ScoreSheetEntityConfiguration : IEntityTypeConfiguration<ScoreSheet>
	//{
	//	public void Configure(EntityTypeBuilder<ScoreSheet> builder)
	//	{
	//		builder
	//			.HasOne(c => c.Match)
	//			.WithOne(p => p.Scoresheet)
	//			.OnDelete(DeleteBehavior.Restrict);

	//		builder
	//			.HasMany(c => c.HomeTeamGoals)
	//			.WithOne(c => c.ScoreSheet)
	//			.OnDelete(DeleteBehavior.Restrict);

	//		builder
	//			.HasMany(c => c.AwayTeamGoals)
	//			.WithOne(c => c.ScoreSheet)
	//			.OnDelete(DeleteBehavior.Restrict);
	//	}
	//}
}
