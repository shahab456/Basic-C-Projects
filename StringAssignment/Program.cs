using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2, str3;
            str1 = "Begin";
            str2 = "Welcome to Programming";
            str3 = "End";

            Console.WriteLine("Concatenate");
            Console.WriteLine(str1  +" "+str2 + " "+str3);
            Console.WriteLine("\nuppercase");
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str2.ToUpper());
            Console.WriteLine(str3.ToUpper());
            Console.WriteLine("\nStringBuiler");
            StringBuilder sb = new StringBuilder(str1);
            sb.Append(". ");
            sb.Append(str2);
            sb.Append(". ");
            sb.Append(str3);
            sb.Append(". ");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
