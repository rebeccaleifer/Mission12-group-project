using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class TourTime
    {
        [Key]
        [Required]
        public int TourTimeId { get; set; }
        public string Time { get; set; }
    }
}
