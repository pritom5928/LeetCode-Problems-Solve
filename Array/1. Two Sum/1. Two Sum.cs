Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]



solution:


public class TestSealed
    {
        class Program
        {
            public static void Main()
            {
                try
                {
                    int[] inputArray = Console.ReadLine().TrimEnd().Split(new char[] { ' ' }, StringSplitOptions.None).Select(s => int.Parse(s)).ToArray();
                    int length = inputArray.Length;

                    int target = int.Parse(Console.ReadLine().Trim());

                    var solution = new Solution();
                    int[] result = solution.TwoSum(inputArray, target);

                    Console.WriteLine(string.Join(",", result));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Not found");
                }
                
            }

        }

        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                //take a hash table to stores elements of array
                Dictionary<int, int> hashSet = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    //find difference from target to current indexed value
                    int compliment = target - nums[i];

                    //if difference exist on hashes then return two index in a array
                    if (hashSet.ContainsKey(compliment))
                    {
                        return new int[] { hashSet[compliment], i };
                    }

                    //if difference not exist on hashes then put current indexed value on hashset
                    hashSet[nums[i]] = i;
                }
                throw new Exception("Not found");
            }
        }
    }