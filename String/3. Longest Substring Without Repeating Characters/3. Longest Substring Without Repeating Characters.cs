3. Longest Substring Without Repeating Characters
Medium

Given a string s, find the length of the longest 
substring
 without repeating characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.


solution with 94 ms runtime beats 43.90% C# submisison with 39.9 MB memory consumption beats 52.16% :

int lengthOfLongestSubstring = new Solution().LengthOfLongestSubstring("abcabcbb");
Console.Write(lengthOfLongestSubstring);

namespace SolveInCSharp
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0, start = 0, end = 0;
            HashSet<char> set = new HashSet<char>();

            while (start < s.Length)
            {
                //check whether the element doesn't exists on the sets, add to set,update start value & assign max value by current set size
                if (!set.Contains(s[start]))
                {
                    set.Add(s[start]);
                    max = Math.Max(max, set.Count);
                    start++;
                }
		//check whether the element exists on the sets i.e duplicate found, clear  set, update end value and set start value from end again to iterate to find new substring
                else
                {
                    end++;
                    start = end;
                    set.Clear();
                }
            }

            return max;
        }

    }
}