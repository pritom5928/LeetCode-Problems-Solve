136. Single Number
Easy
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.

 

Example 1:

Input: nums = [2,2,1]
Output: 1
Example 2:

Input: nums = [4,1,2,1,2]
Output: 4
Example 3:

Input: nums = [1]
Output: 1
 

Constraints:

1 <= nums.length <= 3 * 104
-3 * 104 <= nums[i] <= 3 * 104
Each element in the array appears twice except for one element which appears only once.


Naive solution by hashtable with 101 ms runtime & beats 89.35% C# submissions with 28.40% memory beats:
 public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> values = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                if (!values.ContainsKey(nums[i]))
                    values.Add(nums[i], i);
                else
                    values.Remove(nums[i]);
            }

            return values.Keys.First();
        }


optimal solution by bit manipulation with 100 ms beats 92.30% C# submissions with 53.3% memory beats: 

 public int SingleNumber(int[] nums)
        {
             int xor = 0;
                foreach (int num in nums)
                    xor ^= num;
             return xor;
        }