using System;

namespace Practice
{

    class demo
    {
        public void employee(string name, int id)
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            demo d1 = new demo();//create a instantiated
            d1.employee("Devang", 1943); // pass name and id
        }
    }
}
