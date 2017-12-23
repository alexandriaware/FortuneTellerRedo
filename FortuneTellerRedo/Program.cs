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
            Console.WriteLine("What is your favorite ROYGBIV color?");


            //Where's the vacation home?
            Console.WriteLine("How many siblings do you have?");

        }
    }
}
