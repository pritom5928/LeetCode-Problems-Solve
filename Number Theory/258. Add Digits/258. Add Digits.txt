258. Add Digits
Easy

Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

 

Example 1:

Input: num = 38
Output: 2
Explanation: The process is
38 --> 3 + 8 --> 11
11 --> 1 + 1 --> 2 
Since 2 has only one digit, return it.
Example 2:

Input: num = 0
Output: 0


Naive solution by recursion that beats 88.83%  C# online submissions :

public class Solution
    {
        public int AddDigits(int num)
        {
            int result;
            if (num != 0 && num.ToString().Length > 1)
            {
                result = Result(num, 0);
                if (result != 0 && result.ToString().Length > 1)
                    return AddDigits(result);
            }
            else
                result = num;

            return result;
        }

        public int Result(int input, int result) //38
        {
            if (input != 0)
            {
                // store remainder in this variable. i.e remainder => 38 % 10 => 8
                int remainder = input % 10;
                result += remainder;
                input = input / 10;
                return Result(input, result);
            }
            return result;
        }
    }

