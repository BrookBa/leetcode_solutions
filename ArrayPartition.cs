//Problem URL: https://leetcode.com/problems/array-partition-i/description/
//Date Completed: 12/12/17

public class Solution {
    public int ArrayPairSum(int[] nums) {
        Array.Sort(nums);
        int total = 0;
        for(int i = 0; i < nums.Length - 1; i += 2){
            total += nums[i];
        }
        return total;
    }
}
