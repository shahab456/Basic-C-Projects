using System;

namespace Income_Comparison_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string input11 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string input12 = Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string input21 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string input22 = Console.ReadLine();

            int person1Rate = Convert.ToInt32(input11);
            int person2Rate = Convert.ToInt32(input21);

            int person1Hours= Convert.ToInt32(input12);
            int person2Hours= Convert.ToInt32(input22);

            long person1Salary = 52 * person1Hours * person1Rate;
            long person2Salary = 52 * person2Hours * person2Rate;
            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(person1Salary);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(person2Salary);
            Console.WriteLine("Person 1 makes more money than Person 2?");
            if (person1Salary > person2Salary) Console.WriteLine("True");
            else Console.WriteLine("False");

            Console.ReadKey();
        }
    }
}
