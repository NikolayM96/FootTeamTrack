using FootTeamTracker.Data;
using FootTeamTracker.Data.Models;
using FootTeamTracker.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Services.Data
{
    public class AppUserService : IAppUserService
    {
        private readonly FootTeamTrackerDbContext dbContext;

        public AppUserService(FootTeamTrackerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<string> GetFullNameByEmailAsync(string email)
        {
            AppUser? user = await dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return string.Empty;
            }

            return $"{user.FirstName} {user.LastName}";
        }
    }
}
