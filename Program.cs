using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientID;
            string regDate = "";
            string name, phone, email, adress;
            Registration(out clientID, out regDate, out name, out phone, out email, out adress);

            //Create a new client
            Client Client1 = new Client(name, phone, email, adress, clientID, regDate);
            Console.WriteLine($"{Client1.GetName()} har kundID {Client1.GetClientID()} och registrerades {Client1.GetRegDate()}");
            Registration(out clientID, out regDate, out name, out phone, out email, out adress);

            //Create a new client
            Client Client2 = new Client(name, phone, email, adress, clientID, regDate);
            Console.WriteLine($"{Client2.GetName()} har kundID {Client2.GetClientID()} och registrerades {Client2.GetRegDate()}");

            Console.ReadKey();
        }

        private static void Registration(out int clientID, out string regDate, out string name, out string phone, out string email, out string adress)
        {
            //registration
            Console.WriteLine("registration:");
            Console.WriteLine("Write your name:");
            name = Console.ReadLine();
            Console.WriteLine("phone: ");
            phone = Console.ReadLine();
            Console.WriteLine("email: ");
            email = Console.ReadLine();
            Console.WriteLine("adress: ");
            adress = Console.ReadLine();
            clientID = Client.ClientID();
            regDate = Client.RegDate();
        }
    }
}
