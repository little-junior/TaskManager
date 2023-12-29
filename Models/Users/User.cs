using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Users
{
    internal class User
    {
        public User(string name, string email, Positions position)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
            Position = position;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Positions Position { get; private set; }


    }
}
