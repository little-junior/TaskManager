using DataLayer.DataAccess.Interfaces;
using DataLayer.Services.Interfaces;
using ModelLayer.Enums;
using ModelLayer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealTask = ModelLayer.Task;

namespace DataLayer.Services
{
    public class TechLeaderService : ITechLeaderService
    {
        private readonly IDataManagement<TechLeader>? _techLeaderDataManagement;
        private readonly IDataManagement<RealTask.Task>? _taskDataManagement;
        private readonly IDataManagement<Developer>? _developerDataManagement;

        public TechLeaderService(IDataManagement<TechLeader> teachLeaderDataManagement)
        {
            _techLeaderDataManagement = teachLeaderDataManagement;
        }

        public TechLeaderService(IDataManagement<Developer> developerDataManagement)
        {
            _developerDataManagement = developerDataManagement;
        }

        public TechLeaderService(IDataManagement<RealTask.Task> taskDataManagement)
        {
            _taskDataManagement = taskDataManagement;
        }


        public List<TechLeader> GetTechLeaders()
        {
            return _techLeaderDataManagement.ReadJSON();
        }

        public List<RealTask.Task> GetTechLeaderTasks(TechLeader techLeader)
        {
            return _taskDataManagement.ReadJSON().Where(t => t.Responsible.Id == techLeader.Id).ToList();
        }
        public void AddDeveloper(Developer developer)
        {
            _developerDataManagement.WriteJSON(developer);
        }

        public void UpdateTaskStatus (RealTask.Task task, Status status)
        {
            List<RealTask.Task> tasks = _taskDataManagement.ReadJSON();

            RealTask.Task? existingTask = tasks.FirstOrDefault(t => t.Id == task.Id);

            if (existingTask != null)
            {
                existingTask.UpdateStatus(status);
                
                _taskDataManagement.WriteJSON(tasks);
            }
        }

        public void ApproveTask (RealTask.Task task)
        {
            List<RealTask.Task> tasks = _taskDataManagement.ReadJSON();

            RealTask.Task? existingTask = tasks.FirstOrDefault(t => t.Id == task.Id);

            if (existingTask != null)
            {
                existingTask.SetApproved();

                _taskDataManagement.WriteJSON(tasks);
            }
        }


        public void ChangeTaskResponsible(RealTask.Task task, User responsible)
        {
            List<RealTask.Task> tasks = _taskDataManagement.ReadJSON();

            RealTask.Task? existingTask = tasks.FirstOrDefault(t => t.Id == task.Id);

            if (existingTask != null)
            {
                existingTask.UpdateResponsible(responsible);

                _taskDataManagement.WriteJSON(tasks);
            }
        }
    }
}
