771. Jewels and Stones
Easy
You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".

 

Example 1:

Input: jewels = "aA", stones = "aAAbbbb"
Output: 3
Example 2:

Input: jewels = "z", stones = "ZZ"
Output: 0
 

Constraints:

1 <= jewels.length, stones.length <= 50
jewels and stones consist of only English letters.
All the characters of jewels are unique.

Solve with builtin function with 64ms runtime beats 77.21% & 37 MB memory consumption beats 69.74%:

int result = new Solution().NumJewelsInStones("aA", "aAAbbbb");
Console.Write(result);

namespace SolveInCSharp
{
    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int result = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                if (jewels.Contains(stones[i]))
                    result++;
            }

            return result;
        }
    }

}

Solve with Hashset with 74ms runtime beats 32.22% & 37.1 MB memory consumption beats 46.37%:

 public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int result = 0;

            HashSet<char> jewelChars = new HashSet<char>();
            foreach (char ch in jewels)
                jewelChars.Add(ch);

            for (int i = 0; i < stones.Length; i++)
            {
                if (jewelChars.Contains(stones[i]))
                    result++;
            }

            return result;
        }
    }