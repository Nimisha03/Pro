using Outlet.Demo.BusinessServices.contracts;
using Outlet.Demo.DataServices.contracts;
using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlet.Demo.BusinessServices.services
{
     public class VolunteerService:IVolunteerService
    {
        private readonly IVolunteerDataService _volunteerdataservice;
        public VolunteerService(IVolunteerDataService volunteerdataservice)
        {
            _volunteerdataservice = volunteerdataservice;
        }
        public bool AddVolunteer(Volunteer volunteer)
        {
            return _volunteerdataservice.AddVolunteer(volunteer);
        }
    }
}
