using Outlet.Demo.DataServices.contracts;
using Outlet.Demo.DataServices.Data.context;
using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlet.Demo.DataServices.services
{
    public class VolunteerDataService:IVolunteerDataService
    {
        private readonly ApplicationDbContext _applicationdbcontext;
        public VolunteerDataService(ApplicationDbContext applicationdbcontext)
        {
            _applicationdbcontext = applicationdbcontext;
        }

        public bool AddVolunteer(Volunteer volunteer)
        {
            try
            {

                _applicationdbcontext.Volunteers.Add(new Volunteer()
                {
                    
                    VolunteerName = volunteer.VolunteerName,
                    Location = volunteer.Location,
                    VolunteerOutletId = volunteer.VolunteerOutletId,
                    
                });
                _applicationdbcontext.SaveChanges();
                var updationOfNoOfVolunteers = _applicationdbcontext.Outlets.FirstOrDefault(p => p.OutletId == volunteer.VolunteerOutletId);
                updationOfNoOfVolunteers.NoOfVolunteers ++;
                _applicationdbcontext.Outlets.Update(updationOfNoOfVolunteers);

                _applicationdbcontext.SaveChanges();
                
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
