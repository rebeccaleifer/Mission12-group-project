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
        public DbSet<TourTime> tourtimes { get; set; }
        //public DbSet<TourTime> TourTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MakeAppointment>().HasData(
                new MakeAppointment
                {
                    AppointmentId = 1,
                    GroupName = "test",
                    GroupSize = 4,
                    Email = "blah@blah.com",
                    Phone = "555-555-5555",
                    TourTimeId = 1
                }
                );

            mb.Entity<TourTime>().HasData(
                //Hard Coded (EC to do this dynamically)
                //Monday
                new TourTime { TourTimeId = 1, Time = "Monday 8:00 AM" },
                new TourTime { TourTimeId = 2, Time = "Monday 9:00 AM" },
                new TourTime { TourTimeId = 3, Time = "Monday 10:00 AM" },
                new TourTime { TourTimeId = 4, Time = "Monday 11:00 AM" },
                new TourTime { TourTimeId = 5, Time = "Monday 12:00 PM" },
                new TourTime { TourTimeId = 6, Time = "Monday 1:00 PM" },
                new TourTime { TourTimeId = 7, Time = "Monday 2:00 PM" },
                new TourTime { TourTimeId = 8, Time = "Monday 3:00 PM" },
                new TourTime { TourTimeId = 9, Time = "Monday 4:00 PM" },
                new TourTime { TourTimeId = 10, Time = "Monday 5:00 PM" },
                new TourTime { TourTimeId = 11, Time = "Monday 6:00 PM" },
                new TourTime { TourTimeId = 12, Time = "Monday 7:00 PM" },
                new TourTime { TourTimeId = 13, Time = "Monday 8:00 PM" },
                //Tuesday
                new TourTime { TourTimeId = 14, Time = "Tuesday 8:00 AM" },
                new TourTime { TourTimeId = 15, Time = "Tuesday 9:00 AM" },
                new TourTime { TourTimeId = 16, Time = "Tuesday 10:00 AM" },
                new TourTime { TourTimeId = 17, Time = "Tuesday 11:00 AM" },
                new TourTime { TourTimeId = 18, Time = "Tuesday 12:00 PM" },
                new TourTime { TourTimeId = 19, Time = "Tuesday 1:00 PM" },
                new TourTime { TourTimeId = 20, Time = "Tuesday 2:00 PM" },
                new TourTime { TourTimeId = 21, Time = "Tuesday 3:00 PM" },
                new TourTime { TourTimeId = 22, Time = "Tuesday 4:00 PM" },
                new TourTime { TourTimeId = 23, Time = "Tuesday 5:00 PM" },
                new TourTime { TourTimeId = 24, Time = "Tuesday 6:00 PM" },
                new TourTime { TourTimeId = 25, Time = "Tuesday 7:00 PM" },
                new TourTime { TourTimeId = 26, Time = "Tuesday 8:00 PM" },
                //Wednesday
                new TourTime { TourTimeId = 27, Time = "Wednesday 8:00 AM" },
                new TourTime { TourTimeId = 28, Time = "Wednesday 9:00 AM" },
                new TourTime { TourTimeId = 29, Time = "Wednesday 10:00 AM" },
                new TourTime { TourTimeId = 30, Time = "Wednesday 11:00 AM" },
                new TourTime { TourTimeId = 31, Time = "Wednesday 12:00 PM" },
                new TourTime { TourTimeId = 32, Time = "Wednesday 1:00 PM" },
                new TourTime { TourTimeId = 33, Time = "Wednesday 2:00 PM" },
                new TourTime { TourTimeId = 34, Time = "Wednesday 3:00 PM" },
                new TourTime { TourTimeId = 35, Time = "Wednesday 4:00 PM" },
                new TourTime { TourTimeId = 36, Time = "Wednesday 5:00 PM" },
                new TourTime { TourTimeId = 37, Time = "Wednesday 6:00 PM" },
                new TourTime { TourTimeId = 38, Time = "Wednesday 7:00 PM" },
                new TourTime { TourTimeId = 39, Time = "Wednesday 8:00 PM" },
                //Thursday
                new TourTime { TourTimeId = 40, Time = "Thursday 8:00 AM" },
                new TourTime { TourTimeId = 41, Time = "Thursday 9:00 AM" },
                new TourTime { TourTimeId = 42, Time = "Thursday 10:00 AM" },
                new TourTime { TourTimeId = 43, Time = "Thursday 11:00 AM" },
                new TourTime { TourTimeId = 44, Time = "Thursday 12:00 PM" },
                new TourTime { TourTimeId = 45, Time = "Thursday 1:00 PM" },
                new TourTime { TourTimeId = 46, Time = "Thursday 2:00 PM" },
                new TourTime { TourTimeId = 47, Time = "Thursday 3:00 PM" },
                new TourTime { TourTimeId = 48, Time = "Thursday 4:00 PM" },
                new TourTime { TourTimeId = 49, Time = "Thursday 5:00 PM" },
                new TourTime { TourTimeId = 50, Time = "Thursday 6:00 PM" },
                new TourTime { TourTimeId = 51, Time = "Thursday 7:00 PM" },
                new TourTime { TourTimeId = 52, Time = "Thursday 8:00 PM" },
                //Friday
                new TourTime { TourTimeId = 53, Time = "Friday 8:00 AM" },
                new TourTime { TourTimeId = 54, Time = "Friday 9:00 AM" },
                new TourTime { TourTimeId = 55, Time = "Friday 10:00 AM" },
                new TourTime { TourTimeId = 56, Time = "Friday 11:00 AM" },
                new TourTime { TourTimeId = 57, Time = "Friday 12:00 PM" },
                new TourTime { TourTimeId = 58, Time = "Friday 1:00 PM" },
                new TourTime { TourTimeId = 59, Time = "Friday 2:00 PM" },
                new TourTime { TourTimeId = 60, Time = "Friday 3:00 PM" },
                new TourTime { TourTimeId = 61, Time = "Friday 4:00 PM" },
                new TourTime { TourTimeId = 62, Time = "Friday 5:00 PM" },
                new TourTime { TourTimeId = 63, Time = "Friday 6:00 PM" },
                new TourTime { TourTimeId = 64, Time = "Friday 7:00 PM" },
                new TourTime { TourTimeId = 65, Time = "Friday 8:00 PM" },
                //Saturday
                new TourTime { TourTimeId = 66, Time = "Saturday 8:00 AM" },
                new TourTime { TourTimeId = 67, Time = "Saturday 9:00 AM" },
                new TourTime { TourTimeId = 68, Time = "Saturday 10:00 AM" },
                new TourTime { TourTimeId = 69, Time = "Saturday 11:00 AM" },
                new TourTime { TourTimeId = 70, Time = "Saturday 12:00 PM" },
                new TourTime { TourTimeId = 71, Time = "Saturday 1:00 PM" },
                new TourTime { TourTimeId = 72, Time = "Saturday 2:00 PM" },
                new TourTime { TourTimeId = 73, Time = "Saturday 3:00 PM" },
                new TourTime { TourTimeId = 74, Time = "Saturday 4:00 PM" },
                new TourTime { TourTimeId = 75, Time = "Saturday 5:00 PM" },
                new TourTime { TourTimeId = 76, Time = "Saturday 6:00 PM" },
                new TourTime { TourTimeId = 77, Time = "Saturday 7:00 PM" },
                new TourTime { TourTimeId = 78, Time = "Saturday 8:00 PM" },
                //Sunday
                new TourTime { TourTimeId = 79, Time = "Sunday 8:00 AM" },
                new TourTime { TourTimeId = 80, Time = "Sunday 9:00 AM" },
                new TourTime { TourTimeId = 81, Time = "Sunday 10:00 AM" },
                new TourTime { TourTimeId = 82, Time = "Sunday 11:00 AM" },
                new TourTime { TourTimeId = 83, Time = "Sunday 12:00 PM" },
                new TourTime { TourTimeId = 84, Time = "Sunday 1:00 PM" },
                new TourTime { TourTimeId = 85, Time = "Sunday 2:00 PM" },
                new TourTime { TourTimeId = 86, Time = "Sunday 3:00 PM" },
                new TourTime { TourTimeId = 87, Time = "Sunday 4:00 PM" },
                new TourTime { TourTimeId = 88, Time = "Sunday 5:00 PM" },
                new TourTime { TourTimeId = 89, Time = "Sunday 6:00 PM" },
                new TourTime { TourTimeId = 90, Time = "Sunday 7:00 PM" },
                new TourTime { TourTimeId = 91, Time = "Sunday 8:00 PM" }
            );
        }
    }
}
