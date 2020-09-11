using System;
using System.Linq;
using Problems;

namespace CodeWarsPracticeCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(_002_UniqueInOrder.UniqueInOrder("11233444").ToArray());
            Console.WriteLine(_002_UniqueInOrder.UniqueInOrderExcellent("11233444").ToArray());
        }
    }
}