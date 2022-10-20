using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Palindrome
    {
        public static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: "); //121
            n = int.Parse(Console.ReadLine());
            temp = n;
           while(n>0) 
            {
                r = n % 10; //1,2
                sum = (sum * 10) + r; //1,12
                n = n / 10;//12,
            }

            if (sum == temp)
            {
                Console.WriteLine(temp+" Number is Palindrome");
            }
            else
            {
                Console.WriteLine(temp + " Number is not  Palindrome");
            }
        }
    }
}
