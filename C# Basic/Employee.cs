using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Data
    {
        private string name;
        private int id;
        private string dept;

        public Data(string name,int id,string dept)
        {
            this.name = name;
            this.id = id;
            this.dept = dept;
        }

        public void printData()
        {
            Console.WriteLine("Name is:" + name);
            Console.WriteLine("Id is:" + id);
            Console.WriteLine("Department is:" + dept);
        }
    }
    class Employee
    {
        public static void Main(string[] args)
        {
            Data d1 = new Data("Devang",1943,".Net");
            d1.printData();
        }
    }
}
