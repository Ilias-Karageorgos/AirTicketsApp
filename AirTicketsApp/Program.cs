using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Start();





        }

        static void Start()
        {
            Welcoming();

            PrintOptions();

            string country = GetCountry();

            string name = GetName();

            string ticketType = GetTicketType();

            Console.WriteLine($" TICKET DETAILS \n Name:{name} \n Destrination:{country} \n Ticket Type: {ticketType}");


        }

        static void Welcoming()
        {
            Console.WriteLine("Welcome to our website!");
        }

        static void PrintOptions()
        {
            

            Console.WriteLine($"Please choose your destination");

            List<string> countries = new List<string> { "Italy", "Spain", "Portugal", "Greece" }; ;


            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine($"{i + 1} for {countries[i]}");
            }


        }

        static string GetCountry()
        {
            string countryCode;

            do
            {
                countryCode = Console.ReadLine();

                switch (countryCode)
                {
                    case "1": return "Italy";
                    case "2": return "Spain";
                    case "3": return "Portugal";
                    case "4": return "Greece";


                    default: Console.WriteLine("Options are between 1 and 4"); PrintOptions(); ; break;
                }

            } while (countryCode != "1" && countryCode != "2" && countryCode != "3" && countryCode != "4");

            return "";

        }

        static string GetTicketType()
        {
            Console.WriteLine("Please select \n 1 for one way ticket \n 2 for ticket including return");

            string ticketType;

            do
            {

                ticketType = Console.ReadLine();

                switch (ticketType)
                {
                    case "1": return "One way ticket";
                    case "2": return "Ticket with return";

                    default: Console.WriteLine("Please select \n 1 for one way ticket \n 2 for ticket including return") ; break;
                }
            } while (ticketType != "1" && ticketType !="2");
            return "";
        }

        static string GetName()
        {
            Console.WriteLine("Please fill your fullname");

            string nameGiven = Console.ReadLine();

            return nameGiven;

        }




    }
}
