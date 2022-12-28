344. Reverse String
Easy

Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.


Example 1:

Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]
Example 2:

Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]
 

Constraints:

1 <= s.length <= 105
s[i] is a printable ascii character.

Recursion solution that beats 84.39% online submission :

new Solution().ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });

namespace SolveInCSharp
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            char[] ss = GetData(s, 0, s.Length - 1);
            Console.WriteLine(new String(ss));

        }

        private char[] GetData(char[] s, int start, int end)
        {
            if (start >= end)
                return s;
            else
            {
                char temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
                return GetData(s, start, end);
            }
        }
    }
}


Loop solution that beats 98.60% online submission :

new Solution().ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });


namespace SolveInCSharp
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int start = 0, end = s.Length-1;
            while (start < end)
            {
                char temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
            Console.WriteLine(new String(s));

        }

    }
}

