using DataLayer.DataAccess.Interfaces;
using DataLayer.Services.Interfaces;
using ModelLayer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IDataManagement<Developer> _developerDataManagement;
        private readonly IDataManagement<TechLeader> _techLeaderDataManagement;
        public AuthenticationService(IDataManagement<Developer> developerDataManagement, IDataManagement<TechLeader> techLeaderDataManagement)
        {
            _developerDataManagement = developerDataManagement;
            _techLeaderDataManagement = techLeaderDataManagement;
        }

        public bool AdminAuthenticate(string keyAccess)
        {
            return keyAccess == "admin";
        }

        public Developer? DeveloperAuthenticate(string keyAccess)
        {
            var developers = _developerDataManagement.ReadJSON();
            return developers.FirstOrDefault(d => d.KeyAccess == keyAccess);
        }

        public TechLeader? TechLeaderAuthenticate(string keyAccess)
        {
            var techLeaders = _techLeaderDataManagement.ReadJSON();
            return techLeaders.FirstOrDefault(t => t.KeyAccess == keyAccess);
        }
    }
}
