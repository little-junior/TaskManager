using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Users;

namespace DataLayer.Services.Interfaces
{
    internal interface IAdminService
    {
        void AddTechLeader(TechLeader techLeader);
    }
}
