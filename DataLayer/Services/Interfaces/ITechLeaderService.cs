using ModelLayer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services.Interfaces
{
    internal interface ITechLeaderService
    {
        void CreateTechLeader(TechLeader techLeader);
        List<TechLeader> GetTechLeaders();
    }
}
