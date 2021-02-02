using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlet.Demo.DataServices.contracts
{
    public interface IVolunteerDataService
    {
        bool AddVolunteer(Volunteer volunteer);
    }
}

