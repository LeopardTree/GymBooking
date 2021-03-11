using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBooking
{
    class Client : Person
    {
        // Client variables
        private int _clientID;
        private string _regDate;
        private static int num = 0;

        //constructors
        public Client(string Name, string Phone, string Email, string Adress, int ClientID, string RegDate)
               : base(Name, Phone, Email, Adress)
        {
            
            this._clientID = ClientID;
            this._regDate = RegDate;
            Increase();
        }
        public static string RegDate()
        {
            DateTime thisDay = DateTime.Today;
            return thisDay.ToString("d");
        }
        public static void Increase()
        {
            num++;
        }
        public static int ClientID()
        {
            return num;
        }
        public int GetClientID()
        {
            return _clientID;
        }
        public string GetRegDate()
        {
            return _regDate;
        }
    }
}
