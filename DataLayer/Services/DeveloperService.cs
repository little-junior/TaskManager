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
    public class DeveloperService : IDeveloperService
    {
        private readonly IDataManagement<Developer> _developerDataManagement;

        public DeveloperService(IDataManagement<Developer> developerDataManagement)
        {
            _developerDataManagement = developerDataManagement;
        }

        public List<Developer> GetDevelopers()
        {
            return _developerDataManagement.ReadJSON();
        }
    }
}
