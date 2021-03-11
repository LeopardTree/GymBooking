using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBooking
{
    class Person
    {
        private string _name;
        private string _phone;
        private string _email;
        private string _adress;

        //constructor
        public Person(string Name, string Phone, string Email, string Adress)
        {
            _name = Name;
            _phone = Phone;
            _email = Email;
            _adress = Adress;
        }
        //Accessors
        public string GetName()
        {
            return _name;
        }
        public string GetPhone()
        {
            return _phone;
        }
        public string GetEmail()
        {
            return _email;
        }
        public string GetAdress()
        {
            return _adress;
        }
    }
}
