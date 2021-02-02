using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Outlet.Demo.BusinessServices.contracts
{
    public interface IOutletService
    {
        bool CheckAdmin(Admin adminorg);
        IEnumerable<DataServices.Data.Entities.Outlet1> GetAllOutlets();
        bool DeleteOutlet(int id);
        bool UpdateOutlet(int id, DataServices.Data.Entities.Outlet1 outlet);
        IEnumerable<DataServices.Data.Entities.Outlet1> GetAOutlet(int id);
        bool AddOutlet(DataServices.Data.Entities.Outlet1 outletin);
        bool CheckOutletName(Outlet1 outletin);
    }
}
