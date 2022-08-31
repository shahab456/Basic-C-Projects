using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiply 50");
            Console.WriteLine("Please Input a Number:");
           string input1 = Console.ReadLine();
            long num1 = Convert.ToInt64(input1);
            Console.WriteLine(num1+" * 50 = " + num1*50);
            Console.WriteLine("------------------------");
            Console.WriteLine("add 25");
            Console.WriteLine("Please Input a Number:");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);
            Console.WriteLine(num2 + " + 25 = " + (num2 +25));
            Console.WriteLine("------------------------");

            Console.WriteLine("divide 12.5");
            Console.WriteLine("Please Input a Number:");
            string input3 = Console.ReadLine();
            double num3 = Convert.ToDouble(input3);
            Console.WriteLine(num3 + " / 12.5 = " + num3/12.5);
            Console.WriteLine("------------------------");

            Console.WriteLine("Check to 50");
            Console.WriteLine("Please Input a Number:");
            string input4 = Console.ReadLine();
            int num4 = Convert.ToInt32(input4);
            if(num4>50) Console.WriteLine("Your Number is greater than 50");
            else Console.WriteLine("Your Number is lower than 50");
            Console.WriteLine("------------------------");

            Console.WriteLine("divide by 7");
            Console.WriteLine("Please Input a Number:");
            string input5 = Console.ReadLine();
            double num5 = Convert.ToDouble(input5);
            Console.WriteLine(num5 + " / 7 = " + num5 /7);
            Console.WriteLine(" ");

            Console.Write("Press any key to end");
            Console.Read();
        }
    }
}
