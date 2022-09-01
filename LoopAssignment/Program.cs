using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            int i = num;
            Console.WriteLine("\nWhile loop from "+ num + " to " + num);
            while (i<num) {
                Console.Write(i + " ");
                i++;
                    }

            Console.WriteLine("\n");
            Console.WriteLine("do While loop from "+ num + " to " + num);
            i = num;
            do {
                Console.Write(i + " ");
                i++;
            }while (i < num); 

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
