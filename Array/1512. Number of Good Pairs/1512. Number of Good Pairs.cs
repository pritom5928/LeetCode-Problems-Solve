1512. Number of Good Pairs
Easy

Given an array of integers nums, return the number of good pairs.

A pair (i, j) is called good if nums[i] == nums[j] and i < j.

 

Example 1:

Input: nums = [1,2,3,1,1,3]
Output: 4
Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
Example 2:

Input: nums = [1,1,1,1]
Output: 6
Explanation: Each pair in the array are good.
Example 3:

Input: nums = [1,2,3]
Output: 0
 

Constraints:

1 <= nums.length <= 100
1 <= nums[i] <= 100



naive solution:


using System.ComponentModel;

int[] inputDigits = new int[4] { 1, 1, 1, 1};
int numOfIdenticalPairs = new Solution().NumIdenticalPairs(inputDigits);

Console.WriteLine(numOfIdenticalPairs);

public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        Dictionary<int, int> containers = new Dictionary<int, int>();
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            //check if the element is already in container
            if (containers.ContainsValue(nums[i]))
            {
                result = getDuplicates(containers, result, nums[i], i);
            }
            else
            {
                containers.Add(i, nums[i]);
            }

        }
        return result;
    }

    private int getDuplicates(Dictionary<int, int> containers, int result, int currentValue, int currentIndex)
    {
        foreach (KeyValuePair<int,int> item in containers.ToList())
        {
            //if the current element value equal to previous element value then we increment result and placed current element to next element in container
            if (item.Value == currentValue)
            {
                result++;
                //add current element to container
                containers[currentIndex] = currentValue;
            }

        }
        return result;
    }
}


optimal solution:



using System.ComponentModel;

int[] inputDigits = new int[4] { 1, 1, 1, 1};
int numOfIdenticalPairs = new Solution().NumIdenticalPairs(inputDigits);

Console.WriteLine(numOfIdenticalPairs);

public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        int[] tempArray = new int[101];
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            //tempArray index contains with input array element like tempArray[1], tempArray[2]...
            //increment result with tempArray value
            result += tempArray[nums[i]];
            //increment tempArray value of each iteration
            tempArray[nums[i]]++;
        }
        return result;
    }

}
