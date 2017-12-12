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
