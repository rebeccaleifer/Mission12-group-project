using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class AppointmentContext : DbContext
    {
        //Constructor
        public AppointmentContext(DbContextOptions<AppointmentContext> appointments) : base(appointments)
        {

        }

        public DbSet<MakeAppointment> responses { get; set; }
    }
}
