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
    public class AdminService : IAdminService
    {
        private readonly IDataManagement<TechLeader>? _techLeaderDataManagement;

        public AdminService(IDataManagement<TechLeader>? techLeaderDataManagement)
        {
            _techLeaderDataManagement = techLeaderDataManagement;
        }

        public void AddTechLeader(TechLeader techLeader)
        {
            _techLeaderDataManagement.WriteJSON(techLeader);
        }
    }
}
