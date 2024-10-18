13. Roman to Integer
Easy

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right.
 However, the numeral for four is not IIII. 
Instead, the number four is written as IV.
 Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX.
 There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

 

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

Constraints:

1 <= s.length <= 15
s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
It is guaranteed that s is a valid roman numeral in the range [1, 3999].


O(N) solution:


using System.ComponentModel;

int romanToInt = new Solution().RomanToInt("MCDII");
Console.WriteLine(romanToInt);

public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        //container holds all base roman value
        Dictionary<string, int> container = new Dictionary<string, int>
        {
            {"I", 1 },
            {"IV", 4},
            {"V", 5},
            {"IX", 9},
            {"X", 10},
            {"XL", 40},
            {"L", 50},
            {"XC", 90},
            {"C", 100},
            {"CD", 400},
            {"D", 500},
            {"CM", 900},
            {"M", 1000}
        };

        for (int i = 0; i < s.Length; i++)
        {
            //check if current iterative index is on the last index or not
            //if it is not on the last then it take current and next indexed value and concate it
            //else it is on the last then take only last indexed value
            string currentAndNextCharacter = i < s.Length -1 ?
                 s[i].ToString() + s[i + 1].ToString() : s[i].ToString();

            if (container.ContainsKey(currentAndNextCharacter))
            {
                result += container[currentAndNextCharacter];
                i++;
            }
            else
                result += container[s[i].ToString()];
        }
        return result;
    }
}


1. O(N) with optimal solution:


using System.ComponentModel;

int romanToInt = new Solution().RomanToInt("XL");
Console.WriteLine(romanToInt);

public class Solution
{
    public int RomanToInt(string s)
    {
        //container holds all base roman value
        Dictionary<string, int> container = new Dictionary<string, int>
        {
            {"I", 1 },
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };

        //take last index 
        char indexCharacter = s[s.Length - 1];
        //store last index value from dictionary
        int result = container[indexCharacter.ToString()];

        //starts from the second last index and iterate upto first index
        for (int i = s.Length - 2; i >= 0; i--)
        {
            //if index value is greater or equal to its next value then add otherwise subtract from result
            if (container[s[i].ToString()] >= container[s[i + 1].ToString()])
                result += container[s[i].ToString()];
            else
                result -= container[s[i].ToString()];
        }
        return result;
    }
}

2. another NAIVE solution with linq Runtime 52 ms Beats 67.51%

 public int RomanToInt(string s)
 {
     List<(int, string, int)> symbolValues = new List<(int, string, int)>
     {
         (0, "I", 1),
         (1, "V", 5),
         (2, "X", 10),
         (3, "L", 50),
         (4, "C", 100),
         (5, "D", 500),
         (6, "M", 1000)
     };
     int result = 0;
     for (int i = 0; i < s.Length; i++)
     {
         if(symbolValues.Any(a=>a.Item2 == s[i].ToString()))
         {
             //check if next digit is higher then subtract from its value
             if (i + 1 < s.Length &&
                 symbolValues.FirstOrDefault(a => a.Item2 == s[i + 1].ToString()).Item1 > symbolValues.FirstOrDefault(a => a.Item2 == s[i].ToString()).Item1)
             {
                 result += (symbolValues.FirstOrDefault(a => a.Item2 == s[i + 1].ToString()).Item3 -
                            symbolValues.FirstOrDefault(a => a.Item2 == s[i].ToString()).Item3);
                 i++;
             }
             else
                 result += symbolValues.FirstOrDefault(a => a.Item2 == s[i].ToString()).Item3;
         }
     }
     return result;
 }

3. Fastest optimal solution Runtime 2ms Beats 100%

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> symbolValues = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int result = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            //MCDLXXVI
            int currentValue = symbolValues[s[i]];

            // If the current value is less than the previous value, we subtract it (e.g., IV = 5 - 1 = 4)
            if (currentValue < prevValue)
                result -= currentValue;
            else
                // Otherwise, we add the value
                result += currentValue;

            prevValue = currentValue;
        }
        return result;
    }

}
