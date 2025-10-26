//55.Jump Game
//Solved
//Medium
//Topics
//premium lock icon
//Companies
//You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

//Return true if you can reach the last index, or false otherwise.



//Example 1:

//Input: nums = [2, 3, 1, 1, 4]
//Output: true
//Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
//Example 2:

//Input: nums = [3, 2, 1, 0, 4]
//Output: false
//Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.


//Constraints:

//1 <= nums.length <= 104
//0 <= nums[i] <= 105

//Solution:
public class Solution
{
    public bool CanJump(int[] nums)
    {
        // Hint: Start from back, keep updating target
        int target = nums.Length - 1; // Initial target is to reach last index
        int step = 1;
        int currentPos = nums.Length - 2;
        if (nums.Length < 2)
            return true;

        while (currentPos >= 0)
        {
            //positive scenario
            if (nums[currentPos] >= step)
            {
                target = currentPos;
                step = 1;
                currentPos--;
            }
            //negative scenario (element is 0)
            else
            {
                step++;
                currentPos--;
            }
        }
        if (target == 0)
            return true;
        else
            return false;
    }
}