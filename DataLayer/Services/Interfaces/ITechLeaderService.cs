using ModelLayer.Users;
using RealTask = ModelLayer.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Enums;

namespace DataLayer.Services.Interfaces
{
    internal interface ITechLeaderService
    {
        List<TechLeader> GetTechLeaders();
        List<RealTask.Task> GetTechLeaderTasks(TechLeader techLeader);
        void AddDeveloper(Developer developer);
        void UpdateTaskStatus(RealTask.Task task, Status status);
        void ApproveTask(RealTask.Task task);
        void ChangeTaskResponsible(RealTask.Task task, User responsible);

    }
}
