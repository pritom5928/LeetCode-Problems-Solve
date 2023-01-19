643. Maximum Average Subarray I
Easy
You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

 

Example 1:

Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
Example 2:

Input: nums = [5], k = 1
Output: 5.00000
 

Constraints:

n == nums.length
1 <= k <= n <= 105
-104 <= nums[i] <= 104


Naive solution by nested for loops with 2830 ms runtime & beats 5.88% C# solution

public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double result = 0;
            if (k != 0)
            {
                int max = int.MinValue;

                for (int left = 0, right = k - 1; right < nums.Length; left++, right++)
                {
                    int start = left, sum = 0;
                    while (start <= right)
                    {
                        sum += nums[start];
                        start++;
                    }
                    max = sum > max ? sum : max;
                }
                result = (double) max / k;
            }

            return result;
        }
    }	
	
	
	
Optimal solution with O(n) cpomplexity with 282 ms runtime & beats 94.85% submissions:

public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double result = 0;
            if (k != 0)
            {
                int sum = 0, max = 0;
                for (int i = 0; i < k; i++)
                {
                    sum += nums[i];
                }
                max = sum;

                for (int i = k; i < nums.Length; i++)
                {
                    sum = sum + nums[i] - nums[i - k];
                    max = Math.Max(max, sum);
                }
                result = (double)max / k;
            }
            return result;
        }
    }	