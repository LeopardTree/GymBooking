using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymBooking
{
    class Schedule
    {
        private int month;
        private int year;
        private int day;
        private int hour;
        private string room;

        public Schedule(string Month, string Year, string Day, string Hour, string Room)
        {
            month = Month;
            year = Year;
            day = Day;
            hour =Hour;
            room = Room;
        }
    }
}
