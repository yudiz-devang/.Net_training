using System;
using System.Collections;
namespace StackCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
                //Stack
                 Stack stack = new Stack();       
                if(stack.isempty()){
                    stack.Push(10);
                    stack.Push(20);
                    stack.Push(30);
                    stack.Push(40);
                    stack.Pop();
                    Console.WriteLine($"Top Element is {stack.Peek()}");
                    foreach(object item in stack){
                        Console.WriteLine(item);
                    }
                Console.ReadKey();
                }
                else{
                    Console.WriteLine("Data exists");
                }
                

             

                
        }
    }
}
