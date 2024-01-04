using ModelLayer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services.Interfaces
{
    internal interface IDeveloperService
    {
        List<Developer> GetDevelopers();
    }
}
