171. Excel Sheet Column Number
Easy

Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
 

Example 1:

Input: columnTitle = "A"
Output: 1
Example 2:

Input: columnTitle = "AB"
Output: 28
Example 3:

Input: columnTitle = "ZY"
Output: 701
 

Constraints:

1 <= columnTitle.length <= 7
columnTitle consists only of uppercase English letters.
columnTitle is in the range ["A", "FXSHRXW"].


formula : eg: XKHE :  (N3 * 26^3) + (N2 * 26^2) + (N1 * 26^1) + (N0 * 26^0)


public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        Dictionary<char, int> dataContainer = new Dictionary<char, int>();
        dataContainer.Add('A', 1);
        dataContainer.Add('B', 2);
        dataContainer.Add('C', 3);
        dataContainer.Add('D', 4);
        dataContainer.Add('E', 5);
        dataContainer.Add('F', 6);
        dataContainer.Add('G', 7);
        dataContainer.Add('H', 8);
        dataContainer.Add('I', 9);
        dataContainer.Add('J', 10);
        dataContainer.Add('K', 11);
        dataContainer.Add('L', 12);
        dataContainer.Add('M', 13);
        dataContainer.Add('N', 14);
        dataContainer.Add('O', 15);
        dataContainer.Add('P', 16);
        dataContainer.Add('Q', 17);
        dataContainer.Add('R', 18);
        dataContainer.Add('S', 19);
        dataContainer.Add('T', 20);
        dataContainer.Add('U', 21);
        dataContainer.Add('V', 22);
        dataContainer.Add('W', 23);
        dataContainer.Add('X', 24);
        dataContainer.Add('Y', 25);
        dataContainer.Add('Z', 26);

        ///<summary>
        /// formula : eg: XKHE :  (N3 * 26^3) + (N2 * 26^2) + (N1 * 26^1) + (N0 * 26^0)
        /// </summary>
        int result = 0, currentIteratorPosition = 1;
        char[] chars = columnTitle.ToCharArray();

        for (int i = chars.Length - 1; i >= 0; i--)
        {
            int threshold = Convert.ToInt32(Math.Pow(26, currentIteratorPosition - 1));

            result += dataContainer[chars[i]] * threshold;

            currentIteratorPosition++;
        }

        return result;
    }
}