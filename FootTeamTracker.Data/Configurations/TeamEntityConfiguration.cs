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
	public class TeamEntityConfiguration : IEntityTypeConfiguration<Team>
	{
		public void Configure(EntityTypeBuilder<Team> builder)
		{
			//builder
			//.HasMany(c => c.TrainingSessions)
			//.WithOne(p => p.Team)
			//.HasForeignKey(p => p.TeamId)
			//.OnDelete(DeleteBehavior.Restrict);



			//builder
			//	.HasOne(p => p.Stadium)
			//	.WithOne(t => t.Team)
			//	.OnDelete(DeleteBehavior.Restrict);

		}
	}
}
