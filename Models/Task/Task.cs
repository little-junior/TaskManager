using Models.Enums;
using Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Task
{
    internal class Task
    {
        public Task(string name, string description, User responsible, bool approved, int taskDayTime, Status status)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Responsible = responsible;
            Approved = approved;
            TaskDayTime = taskDayTime;
            Status = status;
        }

        public string Id { get; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public User Responsible { get; private set; }
        public bool Approved { get; private set; }
        public int TaskDayTime { get; private set; }
        public Status Status { get; private set; }

    }
}
