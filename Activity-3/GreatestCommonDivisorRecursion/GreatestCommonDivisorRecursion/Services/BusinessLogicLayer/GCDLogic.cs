/*
 * Jacob Cutler
 * CST-250
 * 02/15/2026
 * Greatest Common Divisor Recursion
 * Activity 3
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisorRecursion.Services.BusinessLogicLayer
{
    internal class GCDLogic
    {
        /// <summary>
        /// Use an iterative approach to find the GCD
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int IterativeGCD(int num1, int num2)
        {
            // Declare and initialize
            int result = 0;
            List<int> divisors1 = new List<int>();
            List<int> divisors2 = new List<int>();

            // Use a for loop to iterate through the numbers and add the divisors to each list
            for (int i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    divisors1.Add(i);
                }

                for (int j = 1; j < num2; j++)
                {
                    if (num2 % j == 0)
                    {
                        divisors2.Add(j);
                    }
                }
            }
            // Iterate through the lists
            foreach (int i in divisors1)
            {
                foreach (int j in divisors2)
                {
                    if (i == j && i > result)
                    {
                        result = i;
                    }
                }
            }
            // Return the greatest common divisor
            return result;
        }
    }
}
