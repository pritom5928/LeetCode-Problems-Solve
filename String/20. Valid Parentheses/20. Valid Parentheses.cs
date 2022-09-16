20. Valid Parentheses
Easy

Share
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.


Optimal solution that beats 98.76% of C# submisisons:

using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

bool result = new Solution().IsValid("([)]"); //"([)]"
Console.WriteLine(result);

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> chars = new Stack<char>();
        char lastOpeningBracket = '\0';//asign null character

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')//insert opening item in every iteration
                chars.Push(c);
            else
            {
                lastOpeningBracket = chars.Count > 0 ? chars.Peek() : '\0'; //if no item exists during iteration then assign null chracter again

                switch (c)
                {
                    case ')':
                        if (lastOpeningBracket == '(')//check opening bracket for case 1 and pop if found
                            chars.Pop();
                        else
                            chars.Push(c); //check opening bracket for case 1 and push if not found
                        break;
                    case '}':
                        if (lastOpeningBracket == '{')
                            chars.Pop();
                        else
                            chars.Push(c);
                        break;
                    case ']':
                        if (lastOpeningBracket == '[')
                            chars.Pop();
                        else
                            chars.Push(c);
                        break;
                }
            }
        }

        if((lastOpeningBracket == '(' || lastOpeningBracket == '{' || lastOpeningBracket == '[') && chars.Count ==0){
            return true;
        }

        return false;
    }

}
