//219.Contains Duplicate II
//Solved
//Easy
//Topics
//premium lock icon
//Companies
//Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

//Example 1:

//Input: nums = [1, 2, 3, 1], k = 3
//Output: true
//Example 2:

//Input: nums = [1, 0, 1, 1], k = 1
//Output: true
//Example 3:

//Input: nums = [1, 2, 3, 1, 2, 3], k = 2
//Output: false

//Constraints:

//1 <= nums.length <= 105
//- 109 <= nums[i] <= 109
//0 <= k <= 105219. Contains Duplicate II
//Solved
//Easy
//Topics
//premium lock icon
//Companies
//Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

//Example 1:

//Input: nums = [1,2,3,1], k = 3
//Output: true
//Example 2:

//Input: nums = [1,0,1,1], k = 1
//Output: true
//Example 3:

//Input: nums = [1,2,3,1,2,3], k = 2
//Output: false

//Constraints:

//1 <= nums.length <= 105
//-109 <= nums[i] <= 109
//0 <= k <= 105

//Solution:

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        // Using static sliding window
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {

            //if new items already exists in the window, return true
            // since index of new item-index of 1st item of window is <=k
            if (set.Contains(nums[i]))
                return true;

            // Add the unique item to nums
            set.Add(nums[i]);

            //maintain window size k
            if (set.Count > k)
                set.Remove(nums[i - k]);
        }
        return false;
    }
}