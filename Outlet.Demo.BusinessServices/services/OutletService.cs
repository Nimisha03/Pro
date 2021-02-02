using Outlet.Demo.BusinessServices.contracts;
using Outlet.Demo.DataServices.contracts;
using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Outlet.Demo.BusinessServices.services
{
    public class OutletService : IOutletService
    {
        private readonly IOutletDataService _outletdataservice;
        public OutletService(IOutletDataService outletdataservice)
        {
            _outletdataservice = outletdataservice;
        }

        public bool CheckAdmin(Admin adminorg)
        {
            var passWordReturned = _outletdataservice.CheckAdmin( adminorg).ToString();
            if (passWordReturned.Equals(adminorg.PassWord,StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false; ;
            }
           

        }
      

        public IEnumerable<Outlet1> GetAllOutlets()
        {
           var alloutlets= _outletdataservice.GetAll();
            return alloutlets;
        }


        public bool DeleteOutlet(int id)
        {
            return _outletdataservice.DeleteOutlet(id);
        }


        public bool UpdateOutlet(int id, DataServices.Data.Entities.Outlet1 outlet)
        {
            _outletdataservice.UpdateOutlet(id, outlet);
            return true;
        }

        public IEnumerable<DataServices.Data.Entities.Outlet1> GetAOutlet(int id)
        {
            return  _outletdataservice.GetAOutlet(id);
            
        }

        public bool AddOutlet(DataServices.Data.Entities.Outlet1 outletin)
        {
            var ifOutletNameExists = CheckOutletName(outletin);
            if(ifOutletNameExists == true)
            {
                return _outletdataservice.AddOutlet(outletin);
            }
            else
            {
                return false;
            }
        }

        public bool CheckOutletName(Outlet1 outletin)
        {
            var namesList = _outletdataservice.CheckOutletName();
            int count = 0;
            foreach (var i in namesList)
            {
                if (outletin.OutletName.Equals(i))
                {
                    count++;
                    break;
                }
            }
                if(count==0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            
        }

       
    }
}
