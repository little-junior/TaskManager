using ModelLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelLayer.Users
{
    public class Developer : User
    {
        public Developer(string name, string email, Specializations specialization, Positions position = Positions.Developer) : base(name, email, position, specialization)
        {
            KeyAccess = KeyAccess.Insert(0, "dev");
        }

        [JsonConstructor]
        public Developer(string id, string name, string email, Specializations specialization, Positions position, string keyAccess) : base(id, name, email, position, specialization, keyAccess)
        {

        }
    }
}
