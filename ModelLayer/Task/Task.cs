using ModelLayer.Enums;
using ModelLayer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelLayer.Task
{
    public class Task
    {
        public Task(string name, string description, User? responsible = null, bool approved = false, int taskDaySpan = 0, Status status = Status.ASerAprovada)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            Responsible = responsible;
            Approved = approved;
            TaskDaySpan = taskDaySpan;
            Status = status;
        }

        [JsonConstructor]
        public Task(string id, string name, string description, User responsible, bool approved, int taskDaySpan, Status status)
        {
            Id = id;
            Name = name;
            Description = description;
            Responsible = responsible;
            Approved = approved;
            TaskDaySpan = taskDaySpan;
            Status = status;
        }

        public string Id { get; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public User? Responsible { get; private set; }
        public bool Approved { get; private set; }
        public int TaskDaySpan { get; private set; }
        public Status Status { get; private set; }

        public void UpdateStatus(Status status)
        {
            Status = status;
        }

        public void SetApproved()
        {
            Approved = true;
        }

        public void UpdateResponsible(User responsible)
        {
            Responsible = responsible;
        }
    }
}
