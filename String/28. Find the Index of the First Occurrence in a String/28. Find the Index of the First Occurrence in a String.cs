28. Find the Index of the First Occurrence in a String
Easy
Topics
Companies
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

Constraints:

1 <= haystack.length, needle.length <= 104
haystack and needle consist of only lowercase English characters.

Naive solution by library function in c# Runtime 56ms Beats 70.95% of users with C# =>

public class Solution {
    public int StrStr(string haystack, string needle) {
        return haystack.IndexOf(needle);
    }
}


optimal solution in c# Runtime 66ms Beats 13.68% of users with C# =>

public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            //iterate upto the item which is the first element of needle
            for (int i = 0; i < (haystack.Length - needle.Length) + 1; i++)
            {
                if(haystack[i] == needle[0])
                {
                    if (haystack.Substring(i, needle.Length) == needle)
                        return i;
                }
            }

            return -1;
        }
    }