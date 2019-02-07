//This Program checks if an integer typed was Even using "if-else" conditional statement
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an if decision block to check for an even number

            Console.WriteLine("Enter an integer value to find if it is a even number and press enter:");

            int input = Int32.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("The entered number was even");
            }
            else
            { 
                Console.WriteLine("The entered number was not an even number");
        }


        }
    }
}
