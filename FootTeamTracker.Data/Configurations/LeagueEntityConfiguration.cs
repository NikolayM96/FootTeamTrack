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
	//public class LeagueEntityConfiguration : IEntityTypeConfiguration<League>
	//{
	//	public void Configure(EntityTypeBuilder<League> builder)
	//	{
	//		builder
	//	.HasMany(c => c.Matches)
	//	.WithOne(p => p.League)
	//	.HasForeignKey(p => p.LeagueId)
	//	.OnDelete(DeleteBehavior.Restrict);

	//		builder
	//.HasMany(c => c.Teams)
	//.WithOne(p => p.League)
	//.HasForeignKey(p => p.LeagueId)
	//.OnDelete(DeleteBehavior.Restrict);

	//	}
	//}
}
