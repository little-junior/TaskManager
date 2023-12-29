using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Users
{
    internal class Developer : User
    {
        public Developer(string name, string email, Specializations specialization, Positions position = Positions.Developer) : base(name, email, position)
        {
            Specialization = specialization;
        }

        public Specializations Specialization { get; private set; }
    }
}
