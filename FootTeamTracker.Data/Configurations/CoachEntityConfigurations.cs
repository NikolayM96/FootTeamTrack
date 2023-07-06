using FootTeamTracker.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Data.Configurations
{
	//public class CoachEntityConfigurations : IEntityTypeConfiguration<Coach>
	//{
	//	public void Configure(EntityTypeBuilder<Coach> builder)
	//	{
	//		builder
	//			.HasOne(c => c.Team)
	//			.WithOne(p => p.Coach)
	//			.HasForeignKey(t => t.CoachId)
	//			.OnDelete(DeleteBehavior.ClientSetNull);




	//	}
	//}
}
