using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class MakeAppointment
    {
        [Key]
        [Required]
        public int AppointmentId { get; set; }
        //[Required]
        public string GroupName { get; set; }
        //[Required]
        //[MaxLength(15)]
        public int GroupSize { get; set; }
        //[Required]
        public string Email { get; set; }
        public string Phone { get; set; }

        // In a different table
        //Build FK relationship
        public int TourTimeId { get; set; }
        public TourTime TourTime { get; set; }


        //public int TourTimeId { get; set; }
        //public TourTime TourTime { get; set; }

        //REQUIREMENTS!!
        //Name of Group
        //Size of Group(Max of 15)
        //Email Address
        //Phone Number(Optional)
        //Tour Time (should be already set, but seen in the form)
    }
}
