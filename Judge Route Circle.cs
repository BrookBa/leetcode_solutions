//Problem Link: https://leetcode.com/problems/judge-route-circle/description/

public class Solution {
    public bool JudgeCircle(string moves) {
        int hDistance = 0;
        int vDistance = 0;
        foreach(Char c in moves)
            {
                switch (c)
                {
                    case 'L':
                        hDistance -= 1;
                        break;
                    case 'R':
                        hDistance += 1;
                        break;
                    case 'U':
                        vDistance += 1;
                        break;
                    case 'D':
                        vDistance -= 1;
                        break;
                }
            }
            if (hDistance == 0 && vDistance == 0)
                return true;
            return false;
    }
}
