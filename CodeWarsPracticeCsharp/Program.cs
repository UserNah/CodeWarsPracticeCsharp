using System;
using System.Linq;

namespace CodeWarsPracticeCsharp
{
    class Program
    {

        static void Main(string[] args)
        {
            //my code
            bool testA = Problems._001_Narcissistic.Narcissistic(153);
            Console.WriteLine(testA);
            
            bool testB = Problems._001_Narcissistic.NarcissisticExcellent(153);
            Console.WriteLine(testB);
        }
    }
}