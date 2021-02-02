using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Outlet.Demo.DataServices.contracts
{
    public interface IOutletDataService
    {
       string CheckAdmin(Admin adminorg);
        IEnumerable<Data.Entities.Outlet1> GetAll();
        bool DeleteOutlet(int id);
        bool UpdateOutlet(int id, Data.Entities.Outlet1 outlet);
        IEnumerable<Data.Entities.Outlet1> GetAOutlet(int id);
        bool AddOutlet(Data.Entities.Outlet1 outletin);
        IEnumerable<string> CheckOutletName();
       

    }
}
