217. Contains Duplicate
Easy
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

 

Example 1:

Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false
Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109




Solution with Hashset of 178ms runtime that beats 95.78% with 55.4 MB Memory consumption beats 13,71%:

bool sqrt = new Solution().ContainsDuplicate(new int[] { 1, 2, 3, 1 });
Console.Write(sqrt);

 public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> sets = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!sets.Contains(nums[i]))
                    sets.Add(nums[i]);
                else
                    return true;
            }
            return false;
        }
    }