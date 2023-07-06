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
	//public class PlayerEntityConfiguration : IEntityTypeConfiguration<Player>
	//{
	//	public void Configure(EntityTypeBuilder<Player> builder)
	//	{
	//			builder
	//	.HasOne(c => c.Team)
	//	.WithMany(p => p.Players)
	//	.HasForeignKey(p => p.TeamId)
	//	.OnDelete(DeleteBehavior.Restrict);



	//	}
	//}
}
