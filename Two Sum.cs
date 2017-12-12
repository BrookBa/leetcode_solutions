//Problem Link: https://leetcode.com/problems/two-sum/description/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int [] ret = {0, 0};
        for(int i = 0; i < nums.Length; ++i){
            for(int j = i +1; j < nums.Length; ++j){
                if(nums[i] + nums[j] == target){
                    ret[0] = i;
                    ret[1] = j;
                    return ret;
                }
            }
        }
        
        return ret;
    }
}
