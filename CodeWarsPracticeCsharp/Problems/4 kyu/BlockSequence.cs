/*
https://www.codewars.com/kata/5e1ab1b9fe268c0033680e5f/train/csharp
4 kyu
Block sequence
Consider the following array:

[1, 12, 123, 1234, 12345, 123456, 1234567, 12345678, 123456789, 12345678910, 1234567891011...]
If we join these blocks of numbers, we come up with an infinite sequence which starts with 112123123412345123456.... The list is infinite.

You will be given an number (n) and your task will be to return the element at that index in the sequence, where 1 ≤ n ≤ 10^18. 
Assume the indexes start with 1, not 0. For example:

solve(1) = 1, because the first character in the sequence is 1. There is no index 0. 
solve(2) = 1, because the second character is also 1.
solve(3) = 2, because the third character is 2.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsPracticeCsharp.Problems
{
    class BlockSequence
    {
        public static int solve(long n)
        {
            string allArray = string.Empty;
            int count = default;
            int sizeOfArray = 1;
            for (int q = 1; q <= n.ToString().Length; q++)
                sizeOfArray *= 10;
            for (long i = 1; i <= sizeOfArray; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    for(int k = 1; k <= j.ToString().Length; k++)
                        ++count;
                    allArray += j.ToString();
                    if (n == count)
                    {
                        //last = j;
                        break;
                    }
                    if(n < count)
                    {
                        while (n != count)
                            count--;
                    }
                }
                //Console.WriteLine();
                if (n == count)
                    break;
            }
            //Console.WriteLine(allArray);
            //Console.WriteLine(allArray[Convert.ToInt32(n-1)]);
            return allArray[Convert.ToInt32(n - 1)] - 48;
        }
    }
}
