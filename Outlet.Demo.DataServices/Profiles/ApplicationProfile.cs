using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Outlet.Demo.DataServices.Profiles
{
    public class ApplicationProfile :AutoMapper.Profile
    {
        public ApplicationProfile()
        {

            CreateMap<Outlet1, OutletDto>();
            CreateMap<Volunteer,VolunteerDto>();
            CreateMap<Admin, AdminDto>();
            CreateMap<OutletDto, Outlet1>();
            CreateMap<VolunteerDto, Volunteer>();
            CreateMap<AdminDto, Admin>();

        }
    }
}
