using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsPracticeCsharp.Problems
{
    class _001_Narcissistic
    {

        //bad is my code
        public static bool Narcissistic(int value)
        {
            int[] valueInArr = new int[value.ToString().Length];
            double result = 0;
            for (int i = 0; i < System.Convert.ToString(value).Length; i++)
            {
                valueInArr[i] = Convert.ToInt32(Convert.ToString(value).Substring(i, 1));
            }
            for (int i = 0; i < valueInArr.GetLength(0); i++)
            {
                result += Math.Pow(valueInArr[i], valueInArr.GetLength(0));
                //Console.WriteLine("{0}:{1}", i, valueInArr[i]);
            }
            //Console.WriteLine("res of sum^pow : {0}", result);
            if (result == value)
                return true;
            else
                return false;
        }
        //Excellent from Kata Test Results
        public static bool NarcissisticExcellent(int value)
        {
            var str = value.ToString();
            return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
        }

        //------------------------------ADDITIONAL------------------------------
        //write digits of number to an array (Integer to Integer Array)
        public void IntegertoIntegerArray()
        {
            int yourInt = 1234567890;
            string yourstring = "1234567890";
            int count = 0;
            int[] result = yourInt.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            foreach (int r in result)
            {
                count++;
                Console.WriteLine("{0} : {1}", count, r);
            }
            count = 0;
            foreach (char c in yourstring)
            {
                count++;
                Console.WriteLine("{0}: {1}", count, Convert.ToInt32(c));
            }

        }
    }
}
