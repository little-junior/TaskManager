using ModelLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ModelLayer.Users
{
    public class User
    {
        public User(string name, string email, Positions position, Specializations specialization)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            Position = position;
            Specialization = specialization;
            KeyAccess = Id.Substring(0, 8);
        }

        [JsonConstructor]
        public User(string id, string name, string email, Positions position, Specializations specialization, string keyAccess)
        {
            Id = id;
            Name = name;
            Email = email;
            Position = position;
            Specialization = specialization;
            KeyAccess = keyAccess;
        }

        //public User(string name, string email, Positions position, Specializations specialization)
        //: this(Guid.NewGuid().ToString(), name, email, position, specialization, Guid.NewGuid().ToString().Substring(0, 8))
        //{
        //}


        public string Id { get; } 
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Positions Position { get; private set; }
        public Specializations Specialization { get; private set; }
        
        public string KeyAccess { get; protected set; }
        



    }
}
