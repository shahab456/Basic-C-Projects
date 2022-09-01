using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriceQuoteApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below");
            Console.WriteLine("Please enter the package weight:");
            string weightinput = Console.ReadLine();
            int weight = Convert.ToInt32(weightinput);
            if (weight > 50) {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                string winput = Console.ReadLine();
                int width = Convert.ToInt32(winput);
                Console.WriteLine("Please enter the package height:");
                string hinput = Console.ReadLine();
                int height= Convert.ToInt32(hinput);
                Console.WriteLine("Please enter the package length:");
                string linput = Console.ReadLine();
                int length = Convert.ToInt32(linput);
                int dimTotal = height + width + length;
                if (dimTotal > 50) {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
                else
                {
                    double cost = Convert.ToDouble((width * height * length * weight)) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $"+cost);
                    Console.WriteLine("Thank you.");
                }
                
            }
            Console.ReadKey();

        }
    }
}
