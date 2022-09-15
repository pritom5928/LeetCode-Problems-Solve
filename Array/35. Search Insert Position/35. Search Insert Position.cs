35. Search Insert Position
Easy

Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104


Naive solution faster than 6.47% c# solution:


public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1;
        int output = GetIndexOfSearch(nums, target, start, end);
        return output;
    }

    private int GetIndexOfSearch(int[] nums, int target, int start, int end)
    {
        int mid = (start + end) / 2;
		
        if (nums[mid] == target)//check if the current element is the target
            return mid;
        else if (nums[start] > target)//check if target value starts before the first indexed value
            return start;
        else if (start == end || start > end)//check if the iteration didn't found any target to the array
            return start + 1;
        else if (nums[mid] < target)//if current mid value less than target then it resides on the right side
            start = mid + 1;
        else if (nums[mid] > target)//if current mid value greater than target then it resides on the left side
            end = mid - 1;

        return GetIndexOfSearch(nums, target, start, end);
    }
}


Quite optimal solution faster than 13.23% C# submission:

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1;
        while (start <= end)
        {
            int mid = (start + end)  / 2;

            if (nums[mid] < target)
                start = mid + 1;
            else if (nums[mid] > target)
                end = mid - 1;
            else
                return mid;
        }
        return start;
    }
}

