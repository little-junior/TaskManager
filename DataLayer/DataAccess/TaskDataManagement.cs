using RealTask = ModelLayer.Task;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DataLayer.DataAccess.Interfaces;
using System.Reflection;

namespace DataLayer.DataAccess
{
    public class TaskDataManagement : IDataManagement<RealTask.Task>
    {
        private readonly string _path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataRepository/tasks.json");

        public List<RealTask.Task> ReadJSON()
        {
            if (File.Exists(_path))
            {
                string json = File.ReadAllText(_path);

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    AllowTrailingCommas = true,
                };

                return JsonSerializer.Deserialize<List<RealTask.Task>>(json, options) ?? new List<RealTask.Task>();
            }

            return new List<RealTask.Task>();
        }

        public void WriteJSON(RealTask.Task task)
        {
            List<RealTask.Task> tasks = ReadJSON();
            tasks.Add(task);

            string json = JsonSerializer.Serialize(tasks.OrderBy(t => t.Name));

            File.WriteAllText(_path, json);
        }

        public void WriteJSON(List<RealTask.Task> tasks)
        {
            string json = JsonSerializer.Serialize(tasks.OrderBy(t => t.Name));

            File.WriteAllText(_path, json);
        }
    }
}
