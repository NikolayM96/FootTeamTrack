using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootTeamTracker.Services.Data.Interfaces
{
    public interface IAppUserService
    {
        Task<string> GetFullNameByEmailAsync(string email);
    }
}
