//Problem URL: https://leetcode.com/problems/hamming-distance/description/

public class Solution {
    public int HammingDistance(int x, int y) {
        int z = x ^ y;
        int counter = 0;
        while(z != 0){
            if((z & 1 ) == 1)
                ++counter;
            z = z >> 1;
        }
        return counter;
    }
}
