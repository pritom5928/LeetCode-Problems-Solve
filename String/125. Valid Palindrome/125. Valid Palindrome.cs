125. Valid Palindrome
Easy

A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
 

Constraints:

1 <= s.length <= 2 * 105
s consists only of printable ASCII characters.


Naive solution which beats 5.31% C# submisisons: 

bool result = new Solution().IsPalindrome("Ten./sion:23");
Console.WriteLine(result);

public class Solution
{
    public bool IsPalindrome(string s)
    {
        string validCharacters = string.Empty;
        bool isPalindrome = true;
        for (int i = 0; i < s.Length; i++)
        {
            if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= '0' && s[i] <= '9'))
                validCharacters += s[i];
        }
        validCharacters = validCharacters.ToLower();
        int length = validCharacters.Length;

        for (int i = 0; i < validCharacters.Length; i++)
        {
            length--;
            if (validCharacters[i] == validCharacters[length])
                continue;
            else
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }
}

optimal solution which beats 57.36% C# submisisons:

public class Solution {
    public bool IsPalindrome(string s)
    {
        char[] chars = s.Where(c=>char.IsLetterOrDigit(c)).ToArray();
        string validCharacters = new string(chars).ToLower();
        int length = validCharacters.Length;
        bool isPalindrome = true;

        for (int i = 0; i < validCharacters.Length; i++)
        {
            length--;
            if (validCharacters[i] == validCharacters[length])
                continue;
            else
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }
}