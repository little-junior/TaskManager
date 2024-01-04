using DataLayer.DataAccess.Interfaces;
using ModelLayer.Task;
using ModelLayer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataLayer.DataAccess
{
    public class TechLeaderDataManagement: IDataManagement<TechLeader>
    {
        private readonly string _path = @"../../../../DataRepository/techleaders.json";

        public List<TechLeader> ReadJSON()
        {
            if (File.Exists(_path))
            {
                string json = File.ReadAllText(_path);

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    AllowTrailingCommas = true,
                };

                return JsonSerializer.Deserialize<List<TechLeader>>(json, options) ?? new List<TechLeader>();
            }

            return new List<TechLeader>();
        }

        public void WriteJSON(TechLeader techLeader)
        {
            List<TechLeader> techLeaders= ReadJSON();
            techLeaders.Add(techLeader);

            string json = JsonSerializer.Serialize(techLeaders);

            File.WriteAllText(_path, json);
        }

        public void WriteJSON(List<TechLeader> techLeaders)
        {
            string json = JsonSerializer.Serialize(techLeaders);

            File.WriteAllText(_path, json);
        }
    }

}
