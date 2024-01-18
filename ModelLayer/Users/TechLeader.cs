using ModelLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ModelLayer.Users
{
    public class TechLeader : User
    {
        public TechLeader(string name, string email, Specializations specialization, Positions position = Positions.TechLeader) : base(name, email, position, specialization)
        {
            KeyAccess = KeyAccess.Insert(0, "tec");
        }

        [JsonConstructor]
        public TechLeader(string id, string name, string email, Specializations specialization, Positions position, string keyAccess) : base(id, name, email, position, specialization, keyAccess)
        {

        }
    }
}
