using System;
using System.Linq;
using Problems;
using CodeWarsPracticeCsharp.Problems._6_kyu;

namespace CodeWarsPracticeCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WhoLikesIt.Likes(new string[0]));
            Console.WriteLine(WhoLikesIt.Likes(new string[] { "Jacob", "Aiza", "Alex", "Ash" }));
        }
    }
}