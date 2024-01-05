using DataLayer.DataAccess.Interfaces;
using DataLayer.Services.Interfaces;
using ModelLayer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealTask = ModelLayer.Task;
namespace DataLayer.Services
{
    public class DeveloperService : IDeveloperService
    {
        private readonly IDataManagement<Developer> _developerDataManagement;
        private readonly IDataManagement<RealTask.Task> _taskDataManagement;

        public DeveloperService(IDataManagement<Developer> developerDataManagement)
        {
            _developerDataManagement = developerDataManagement;
        }

        public DeveloperService(IDataManagement<RealTask.Task> taskDataManagement)
        {
            _taskDataManagement = taskDataManagement;
        }

        public List<Developer> GetDevelopers()
        {
            return _developerDataManagement.ReadJSON();
        }

        public List<RealTask.Task> GetTasksByDeveloper(string userId)
        {
            return _taskDataManagement.ReadJSON().FindAll(t => t.Responsible.Id == userId);
        }
    }
}
