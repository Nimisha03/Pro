using Outlet.Demo.DataServices.contracts;
using Outlet.Demo.DataServices.Data.context;
using Outlet.Demo.DataServices.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Outlet.Demo.DataServices.services
{
    public class OutletDataService : IOutletDataService
    {
        private readonly ApplicationDbContext _applicationdbcontext;
        public OutletDataService(ApplicationDbContext applicationDbContext)
        {
            _applicationdbcontext = applicationDbContext;
        }


        public string CheckAdmin(Admin adminorg)
        {

            var passwordOfUser = _applicationdbcontext.Admins.FirstOrDefault(p => p.UserName.ToLower() == adminorg.UserName.ToLower()).PassWord;
            return passwordOfUser;
            

        }


        public IEnumerable<Outlet1> GetAll()
        {           
            var orderedListOfOutlets = _applicationdbcontext.Outlets.Where(c => c.Date >= DateTime.Today && c.Date <= DateTime.Today.AddDays(3));
            return orderedListOfOutlets.OrderBy(c => c.FoodType).OrderBy(c=>c.Date).OrderBy(c=>c.StreetName);
        }

        public bool DeleteOutlet(int id)
        {
            try
            {
                var deleteone = _applicationdbcontext.Outlets.FirstOrDefault(d => d.OutletId == id);
                _applicationdbcontext.Outlets.Remove(deleteone);
                _applicationdbcontext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateOutlet(int id, Data.Entities.Outlet1 outlet)
        {
            try
            {
                    var existingOutlet = _applicationdbcontext.Outlets.FirstOrDefault(p => p.OutletId == id);
                if (outlet != null)
                {
                    existingOutlet.OutletName = outlet.OutletName;
                    existingOutlet.StreetName = outlet.StreetName;
                    existingOutlet.Landmark = outlet.Landmark;
                    existingOutlet.NoOfPackets = outlet.NoOfPackets;
                    existingOutlet.NoOfVolunteers = outlet.NoOfVolunteers;
                    existingOutlet.FoodType = outlet.FoodType;
                    existingOutlet.Date = outlet.Date;
                    _applicationdbcontext.Outlets.Update(existingOutlet);
                    _applicationdbcontext.SaveChanges();
                }
               
                   
                    return true;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public IEnumerable<Data.Entities.Outlet1> GetAOutlet(int id)
        {
            var reqRecord = _applicationdbcontext.Outlets.FirstOrDefault(p => p.OutletId == id);
            yield return reqRecord;
        }


        public bool AddOutlet(Data.Entities.Outlet1 outletin)
        {
            try
            {
                var outletsPerDayServingBothFood = _applicationdbcontext.Outlets.Where(x => x.Date == outletin.Date).Where(x => x.FoodType == "Both");
                var outletsServingBothFoodCount = outletsPerDayServingBothFood.Count();
                var outletsPerDay = _applicationdbcontext.Outlets.Where(p => p.Date == outletin.Date);
                var outletsPerDayCount = outletsPerDay.Count();

                if (outletsPerDayCount < 10 && outletsServingBothFoodCount < 3)
                {
                    _applicationdbcontext.Outlets.Add(new Outlet1()
                    {
                        OutletId = outletin.OutletId,
                        OutletName = outletin.OutletName,
                        StreetName = outletin.StreetName,
                        Landmark = outletin.Landmark,
                        NoOfPackets = outletin.NoOfPackets,
                        NoOfVolunteers = outletin.NoOfVolunteers,
                        FoodType = outletin.FoodType,
                        Date = outletin.Date,
   

                    });
 
                    _applicationdbcontext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                

            }
            catch (Exception)
            {
                throw;
            }

        }

        public  IEnumerable<string> CheckOutletName()
        {
            return _applicationdbcontext.Outlets.Select(p => p.OutletName);
        }


    }
}