using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string input1 = Console.ReadLine();
            int age = Convert.ToInt32(input1);
            
            Console.WriteLine("Have you ever had a DUI?(y/n)");
            string input2 = Console.ReadLine();
            bool haveDUI=false;
            if (input2.ToLower() == "n" || input2.ToLower() == "false") haveDUI = true;
           
            Console.WriteLine("How many speeding tickets do you have?");
            string input3 = Console.ReadLine();
            int tickets = Convert.ToInt32(input3);

            Console.WriteLine("Qualified?");
            if (age > 15 && !haveDUI && tickets <= 3) Console.WriteLine("True");
            else Console.WriteLine("False");
            Console.ReadKey();
        }
    }
}
