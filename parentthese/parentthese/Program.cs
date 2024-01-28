using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parentthese
{
    internal class Program
    {
        static void Main(string[] args)
        {





            // Creating a stack of integers
            Stack<int> myStack = new Stack<int>();

            // Pushing elements onto the stack
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);

            // Peeking at the top element without removing it
            int topElement = myStack.Peek();
        //    Console.WriteLine($"Top element: {topElement}");

            // Popping elements off the stack
            int poppedElement = myStack.Pop();
            Console.WriteLine($"Popped element: {poppedElement}");

            // The stack is now: 20, 10

            // Iterating through the stack
            Console.WriteLine("Stack elements:");
            foreach (int element in myStack)
            {
                //Console.WriteLine(element);
            }



            Console.ReadKey();




        }
    }
}
