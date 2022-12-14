using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Factorial
    {
        public static void Main(string[] args)
        {
            int num,fact=1,i;
            Console.Write("Enter the Number: ");
            num = int.Parse(Console.ReadLine());
            for (i=1; i<=num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is: " + fact);
        }
    }
}
