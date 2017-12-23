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
            Console.WriteLine("What month were you born in?");


            //What will you drive?
            Console.WriteLine("What is your favorite ROYGBIV color?");


            //Where's the vacation home?
            Console.WriteLine("How many siblings do you have?");

        }
    }
}
