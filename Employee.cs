using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBooking
{
    class Employee:Person
    {
        private string _type;
        private int _employeeID;
        private static int num = 0;

        public Employee(string Name, string Phone, string Email, string Adress,string Type, int EmployeeID )
               : base(Name, Phone, Email, Adress)
        {
            this._type = Type;
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
