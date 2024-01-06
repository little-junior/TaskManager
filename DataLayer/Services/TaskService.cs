using DataLayer.DataAccess.Interfaces;
using DataLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealTask = ModelLayer.Task;

namespace DataLayer.Services
{
    public class TaskService : ITaskService
    {
        private readonly IDataManagement<RealTask.Task> _taskDataManagement;
        public TaskService(IDataManagement<RealTask.Task> taskDataManagement)
        {
            _taskDataManagement = taskDataManagement;
        }
        public void CreateTask(RealTask.Task task)
        {
            _taskDataManagement.WriteJSON(task);
        }

        public void UpdateTask(List<RealTask.Task> tasks)
        {
            _taskDataManagement.WriteJSON(tasks);
        }

        public List<RealTask.Task> GetTasks()
        {
            return _taskDataManagement.ReadJSON();
        }
    }
}
