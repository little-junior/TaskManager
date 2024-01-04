using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Users;

namespace DataLayer.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Developer? DeveloperAuthenticate(string keyAccess);
        TechLeader? TechLeaderAuthenticate(string keyAccess);

        bool AdminAuthenticate(string keyAccess);
    }
}
