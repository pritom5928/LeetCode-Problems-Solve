345. Reverse Vowels of a String
Easy
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

Example 1:

Input: s = "hello"
Output: "holle"
Example 2:

Input: s = "leetcode"
Output: "leotcede"
 

Constraints:

1 <= s.length <= 3 * 105
s consist of printable ASCII characters.


Naive approach with 89 ms runtime that beats 88.38% C# submissions: 

	Console.WriteLine(new Solution().ReverseVowels("leetcode"));


namespace SolveInCSharp
{
    public class Solution
    {
        public string ReverseVowels(string s)
        {
            int start = 0, end = s.Length - 1;
            char[] inputs = s.ToCharArray();
            while (start < end)
            {
                if (IsVowel(inputs[start]) && IsVowel(inputs[end]))
                {
                    char tempChar = inputs[start];
                    inputs[start] = inputs[end];
                    inputs[end] = tempChar;
                    start++;
                    end--;
                }
                else if (IsVowel(inputs[start]) && !IsVowel(inputs[end]))
                    end--;
                else if (!IsVowel(inputs[start]) && IsVowel(inputs[end]))
                    start++;
                else
                {
                    start++;
                    end--;
                }
            }

            return new String(inputs);
        }

        private bool IsVowel(char v)
        {
            if ((v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u') || (v == 'A' || v == 'E' || v == 'I' || v == 'O' || v == 'U'))
                return true;

            return false;
        }
    }
}

Little improvements: 


 public class Solution
    {
        public string ReverseVowels(string s)
        {
            int start = 0, end = s.Length - 1;
            char[] inputs = s.ToCharArray();
            while (start < end)
            {
                if (IsVowel(inputs[start]) && IsVowel(inputs[end]))
                {
                    char tempChar = inputs[start];
                    inputs[start] = inputs[end];
                    inputs[end] = tempChar;
                    start++;
                    end--;
                }
                else if (IsVowel(inputs[start]) && !IsVowel(inputs[end]))
                    end--;
                else if (!IsVowel(inputs[start]) && IsVowel(inputs[end]))
                    start++;
                else
                {
                    start++;
                    end--;
                }
            }
            return new String(inputs);
        }

        private bool IsVowel(char v)
        {
            return ((v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u') || (v == 'A' || v == 'E' || v == 'I' || v == 'O' || v == 'U'));
        }
    }