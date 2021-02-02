using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Outlet.Demo.DataServices.Data.Entities
{
    public class Volunteer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string VolunteerName { get; set; }

        public string Location { get; set; }

        
        public int VolunteerOutletId { get; set; }
        [ForeignKey("VolunteerOutletId")]
        public Outlet1 OutletI { get; set; }
       
        
        
    }   
}
