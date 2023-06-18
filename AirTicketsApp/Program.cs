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
            WelcomeAndPrintOptions();

            string country = GetCountry();

            string name = GetName();

            


        }

        static void  WelcomeAndPrintOptions()
        {
            Console.WriteLine("Welcome to our website!");

            Console.WriteLine($"Please choose your destination");

            List    <string> countries = new List<string> { "Italy", "Spain", "Portugal", "Greece" }; ;


            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine($"{i+1} for {countries[i]}");
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


                    default: Console.WriteLine("Please Choose between 1 and 4"); break;
                }

            } while (countryCode != "1" && countryCode != "2" && countryCode !="3" && countryCode !="4");

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
