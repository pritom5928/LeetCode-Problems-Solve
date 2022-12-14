58. Length of Last Word
Easy

Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.

 

Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.
Example 2:

Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.
Example 3:

Input: s = "luffy is still joyboy"
Output: 6
Explanation: The last word is "joyboy" with length 6.
 

Constraints:

1 <= s.length <= 104
s consists of only English letters and spaces ' '.
There will be at least one word in s.

Naive approach with trim function that beats 56.67% C# submissions:  

using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

int result = new Solution().LengthOfLastWord("   fly me   to   the moon  "); 
Console.WriteLine(result);

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        int result = 0;
        for (int i = s.Length-1; i >= 0; i--)
        {
            if (s[i] == ' ')
                break;

            result++;
        }

        return result;
    }
}

Naive approach without trim function that beats 72.39%% C# submissions:  

using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

int result = new Solution().LengthOfLastWord("   fly me   to   the moon  ");
Console.WriteLine(result);

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int result = 0;
        bool isLetterFound = false;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                isLetterFound = true;
                result++;
            }
            else if (s[i] == ' ' && !isLetterFound)
                continue;
            else
                break;
        }

        return result;
    }
}