using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBooking
{
    class Employee:Person
    {
        private string _profession;
        private int _employeeID;
        private static int num = 0;

        public Employee(string Name, string Phone, string Email, string Adress,string Profession, int EmployeeID )
               : base(Name, Phone, Email, Adress)
        {
            this._profession = Profession;
            this._employeeID = EmployeeID;
        }

        public static void Increase()
        {
            num++;
        }
        public static int EmployeeID()
        {
            return num;
        }
        public int GetEmployeeID()
        {
            return _employeeID;
        }

    }
}
