using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Fibbonacci
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, num;
            Console.Write("Enter the limit: ");
            num = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2+" ");
            for(i=2; i<num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
