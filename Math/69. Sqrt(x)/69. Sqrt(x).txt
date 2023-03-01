69. Sqrt(x)
Easy
Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

You must not use any built-in exponent function or operator.

For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
 

Example 1:

Input: x = 4
Output: 2
Explanation: The square root of 4 is 2, so we return 2.
Example 2:

Input: x = 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
 

Constraints:

0 <= x <= 231 - 1


solution with 24 ms runtime that beats 83.84% with 26.7 MB memory consumption that beats 37.18%:

public class Solution {
    public int MySqrt(int x)
        {
            double result = 0;
            if(x > 0)
            {
                double initial = x / 2;
                double diff = 1;
                while (Math.Abs(diff) > 0.0001)
                {
                    if (x > 1)
                    {
                        result = (initial + (x / initial)) / 2;
                        diff = initial - result;
                        initial = result;
                    }
                    else
                    {
                        result = 1;
                        diff = 0;
                    }
                }
            }
            return Convert.ToInt32(Math.Floor(result));
        }
}