using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Human
    {
        public void walk()
        {
            Console.WriteLine("walking..");
        }
    }
    class Men : Human
    {
        public void eating()
        {
            Console.WriteLine("Men eating food");
        }
    }
    class Inheritance
    {

        static void Main(string[] args)
        {
            Men m1 = new Men();
            m1.eating();
            m1.walk();
        }
    }
}
