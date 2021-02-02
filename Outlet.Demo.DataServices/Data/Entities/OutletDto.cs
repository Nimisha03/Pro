using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outlet.Demo.DataServices.Data.Entities
{
    public class OutletDto
    {
      
        public string OutletName { get; set; }
        public string StreetName { get; set; }
        public string Landmark { get; set; }
        public int NoOfPackets { get; set; }
        public int NoOfVolunteers { get; set; }
        public string FoodType { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

    }
}
