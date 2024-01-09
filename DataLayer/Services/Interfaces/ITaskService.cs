using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealTask = ModelLayer.Task;

namespace DataLayer.Services.Interfaces
{
    internal interface ITaskService
    {
        void CreateTask(RealTask.Task task);
        List<RealTask.Task> GetTasks();

        void UpdateTask(List<RealTask.Task> tasks);
    }
}
