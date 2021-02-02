using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Outlet.Demo.DataServices.Data.Entities
{
    
    public class Outlet1
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OutletId { get; set; }
        
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
