using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Users
{
    internal class TechLeader : User
    {
        public TechLeader(string name, string email, Positions position = Positions.TechLeader) : base(name, email, position)
        {
        }
    }
}
