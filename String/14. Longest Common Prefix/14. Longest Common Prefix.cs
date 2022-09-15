14. Longest Common Prefix
Easy

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters.


optimal solution that beats 28.94% C# submission:

public class Solution {
   public string LongestCommonPrefix(string[] strs)
    {
        string result = "";

        //sort the array
        Array.Sort(strs);

        //take first and last string
        char[] firstString = strs[0].ToCharArray();
        char[] lastString = strs[strs.Length-1].ToCharArray();

        for (int i = 0; i < firstString.Length; i++)
        {
            if (firstString[i] != lastString[i])//compare first and last string value
                break;
            result += firstString[i];
        }


        return result;
    }
}