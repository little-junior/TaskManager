using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DataLayer.DataAccess.Interfaces;
using ModelLayer.Task;
using ModelLayer.Users;

namespace DataLayer.DataAccess
{
    public class DeveloperDataManagement : IDataManagement<Developer>
    {
        private readonly string _path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataRepository/developers.json");

        public List<Developer> ReadJSON()
        {
            if (File.Exists(_path))
            {
                string json = File.ReadAllText(_path);

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    AllowTrailingCommas = true,
                };

                return JsonSerializer.Deserialize<List<Developer>>(json, options) ?? new List<Developer>();
            }

            return new List<Developer>();
        }

        public void WriteJSON(Developer developer)
        {
            List<Developer> developers = ReadJSON();
            developers.Add(developer);

            string json = JsonSerializer.Serialize(developers);

            File.WriteAllText(_path, json);
        }

        public void WriteJSON(List<Developer> developers)
        {
            string json = JsonSerializer.Serialize(developers);

            File.WriteAllText(_path, json);
        }
    }
}
