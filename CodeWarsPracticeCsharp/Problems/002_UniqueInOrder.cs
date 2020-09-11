using System;
/*
https://www.codewars.com/kata/54e6533c92449cc251001667/csharp
6 kyu
Unique In Order
Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any 
elements with the same value next to each other and preserving the original order of elements.
For example:
uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
uniqueInOrder([1,2,2,3,3])       == {1,2,3}
*/
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    class _002_UniqueInOrder
    {
        //bad
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> newArr = new List<T>();
            foreach (var c in iterable.ToList())
            {
                if (newArr.Count == 0 || newArr.LastOrDefault() == null || !newArr.LastOrDefault().Equals(c))
                    newArr.Add(c);
            }
            return newArr;
        }
        //Excellent from Kata Test Results
        public static IEnumerable<T> UniqueInOrderExcellent<T>(IEnumerable<T> iterable)
        {
            T previous = default;
            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }
        }
    }
}
