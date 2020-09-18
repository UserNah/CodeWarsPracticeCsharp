using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsPracticeCsharp.Problems
{
    class CanWeDivideIt
    {
        public static bool is_divide_by(int number, int a, int b)
            => number % a == 0 && number % b == 0;
    }
}
