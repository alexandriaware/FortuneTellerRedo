using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take in first name and last name and store in all uppercase
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine().ToUpper();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine().ToUpper();


            //How long till retirement?
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            int retirement;
            
            if ((age % 2) == 0)
            {
                retirement = 10;
            }
            else
            {
                retirement = 15;
            }


            //How fat is your bank account?
            Console.WriteLine("What month were you born in? Give a number.");
            int month = int.Parse(Console.ReadLine());
            string money;

            if (month >= 1 && month <= 4)
            {
                money = "$10,000";
            }
            else if (month >= 5 && month <= 8)
            {
                money = "$2,850";
            }
            else if (month >=9 && month <= 12)
            {
                money = "$91.08";
            }
            else
            {
                money = "nothing";
            }


            //What will you drive?
            Console.WriteLine("What is your favorite ROYGBIV color? Say \"help\" to list your options.");
            string color = Console.ReadLine().ToLower();

            if (color == "help")
            {
                Console.WriteLine("Choose from red, orange, yellow, green, blue, indigo, or violet.");
            }

            switch (color)
            {
                case ("red"):
                    color = "Motorized Scooter";
                    break;

                case ("orange"):
                    color = "Chubby Pony";
                    break;

                case ("yellow"):
                    color = "Hearse";
                    break;

                case ("green"):
                    color = "Nissan Leaf";
                    break;

                case ("blue"):
                    color = "Hoverboard";
                    break;

                case ("indigo"):
                    color = "Shopping Cart";
                    break;

                case ("violet"):
                    color = "Tesla Model S Hybrid";
                    break;

                default:
                    color = "squeaky rollerskates";
                    break;
            }


            //Where's the vacation home?
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            string city;

            if (siblings == 0)
            {
                city = "Amsterdam";
            }
            else if (siblings == 1)
            {
                city = "New York City";
            }
            else if (siblings == 2)
            {
                city = "London";
            }
            else if (siblings == 3)
            {
                city = "Dubai";
            }
            else if (siblings > 3)
            {
                city = "Orlando";
            }
            else
            {
                city = "WWII Germany";
            }


            //results
            Console.WriteLine("Here's your fortune:");
            Console.WriteLine(firstName + " " + lastName + " will retire in " + retirement + " years with " + money + " in the bank, a \nvacation home in " + city + ", and a " + color + ".");
            
        }
    }
}
