using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymBooking
{
    class Schedule
    {
        private string month;
        private string year;
        private string day;
        private int hour;
        private string room;

        public Schedule(string Month, string Year, string Day, int Hour, string Room)
        {
            month = Month;
            year = Year;
            day = Day;
            hour = Hour;
            room = Room;
        }
        ////Accessors
        //public string GetName()
        //{
        //    return _name;
        //}
        //public string GetPhone()
        //{
        //    return _phone;
        //}
        //public string GetEmail()
        //{
        //    return _email;
        //}
        //public string GetAdress()
        //{
        //    return _adress;
        //}
    }
}
