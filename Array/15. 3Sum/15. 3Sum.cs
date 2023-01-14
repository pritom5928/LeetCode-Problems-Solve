15. 3Sum
Medium
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.

 

Example 1:

Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation: 
nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
The distinct triplets are [-1,0,1] and [-1,-1,2].
Notice that the order of the output and the order of the triplets does not matter.
Example 2:

Input: nums = [0,1,1]
Output: []
Explanation: The only possible triplet does not sum up to 0.
Example 3:

Input: nums = [0,0,0]
Output: [[0,0,0]]
Explanation: The only possible triplet sums up to 0.
 

Constraints:

3 <= nums.length <= 3000
-105 <= nums[i] <= 105


Solution with 224ms runtime that beats 68.16% C# submission has o(n^2) complexity:


var result = new Solution().ThreeSum(new int[] { 0,0,0,0 });

namespace SolveInCSharp
{
    public class Solution
    {

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();

            Array.Sort(nums);  // -4, -1, -1, 0, 1, 2

            for (int i = 0; i < nums.Length; i++)
            {
                // check current & previous value both are equal
                if (i > 0 && nums[i - 1] == nums[i])
                    continue;

                int left = i + 1, right = nums.Length - 1;

                while (left < right)
                {
                    int threeSum = nums[i] + nums[left] + nums[right];

                    //if 3sum become 0 we shift left pointer && previous left == current le
                    if (threeSum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        
                        left++;
                        while (nums[left] == nums[left - 1] && left < right)
                        {
                            left++;
                        }
                    }
                    else if (threeSum > 0)
                        right--;
                    else
                        left++;
                }
            }

            return result;
        }
    }
}


