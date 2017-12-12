//Problem URL: https://leetcode.com/problems/number-complement/description/

public class Solution {
    public int FindComplement(int num) {
        int exponent = 0;
        int temp = num;
        while(temp != 0){
            temp = temp >> 1;
            ++exponent;
        }
        double twopower = Math.Pow(2, (double)exponent);
        return num ^ ((int)twopower - 1);
    }
}
