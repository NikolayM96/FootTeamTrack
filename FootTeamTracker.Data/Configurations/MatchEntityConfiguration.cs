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
	//public class MatchEntityConfiguration : IEntityTypeConfiguration<Match>
	//{
	//	public void Configure(EntityTypeBuilder<Match> builder)
	//			{
	//				builder
	//		.HasOne(c => c.Scoresheet)
	//		.WithOne(p => p.Match)
	//		.OnDelete(DeleteBehavior.Restrict);

	//				builder
	//		.HasOne(c => c.League)
	//		.WithMany(p => p.Matches)
	//		.HasForeignKey(p => p.LeagueId)
	//		.OnDelete(DeleteBehavior.Restrict);

		



	//			}

	
	//}
}
