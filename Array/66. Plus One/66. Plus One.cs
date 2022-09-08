66. Plus One
Easy

You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

 

Example 1:

Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].
Example 2:

Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].
Example 3:

Input: digits = [9]
Output: [1,0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1,0].



Solution: 




int[] inputDigits = new int[3] { 4,5,9 };
int[] outputDigits = new Solution().PlusOne(inputDigits);

//Console.WriteLine(outputDigits);

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        Dictionary<int, int> results = new Dictionary<int, int>();
        bool isAllElementRemainZero = false;

        for (int i = 0; i < digits.Length; i++)
        {
            //check the iteration on last element
            if (!results.ContainsKey(i) && i == digits.Length - 1)
            {
                digits[i] += 1;
                results.Add(i, digits[i]);

                //if the array has only one elemnet and value is 9
                if (digits[i] % 10 == 0 && i == 0)
                {
                    results[i] = 1;
                    results[i + 1] = 0;
                }

                //if the array has more than one element
                else if (digits[i] % 10 == 0 && i > 0)
                {
                    results[i] = 0;

                    //if last element is 9 then go back to check all previous value. the loop iterate before the last element and go back upto 0 indexed
                    for (int j = i - 1; j >= 0; j--)
                    {
                        //check previous element is 9 
                        if ((results[j] + 1) % 10 == 0)
                        {
                            results[j] = 0;
                            isAllElementRemainZero = true;
                        }
                        //check previous element is not 9
                        else
                        {
                            results[j] += 1;
                            isAllElementRemainZero = false;
                            break;
                        }
                    }
                }
            }

            //insert all elements before last element
            else if (!results.ContainsKey(i))
            {
                results.Add(i, digits[i]);
            }
        }

        //declare the output array.
        //if all the elements of dictionary is 0 then the MSD should 1 and the output array size increment 1 for this. otherwise the output array size remain same as dictionary size
        int[] plusOneArray = isAllElementRemainZero == true ? new int[results.Count + 1] : new int[results.Count];

        for (int i = 0; i < results.Count; i++)
        {
            //add 1 as MSD if all value of dictionary reamins 0
            if (isAllElementRemainZero)
            {
                plusOneArray[i] = 1;
                plusOneArray[i + 1] = results.TryGetValue(i, out int result) ? result : 0;
                isAllElementRemainZero = false;
            }
            //add dictionary value to output array
            else
            {
                plusOneArray[i] = results.TryGetValue(i, out int result) ? result : 0;
            }

        }

        return plusOneArray;
    }
}