169. Majority Element
Easy
Topics
Companies
Given an array nums of size n, return the majority element.

The majority element is the element that appears more than [n / 2] times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109
 

Follow-up: Could you solve the problem in linear time and in O(1) space?

Solution Runtime 89ms Beats 91.65% of users with C# =>

public class Solution {
    public int MajorityElement(int[] nums) {
        int counter = 0, result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(counter == 0)
                   result = nums[i];

                if (result == nums[i])
                    counter++;
                else
                    counter--;
                
            }

            return result;
    }
}