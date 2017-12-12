//Problem Link: https://leetcode.com/problems/self-dividing-numbers/description/

public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        int iter = left;
            IList<int> ret = new List<int>();
            while(iter <= right)
            {
                if (IsSelfDividing(iter))
                {
                    ret.Add(iter);
                }
                iter += 1;
            }
            return ret;
        }

        public static bool IsSelfDividing(int i)
        {
            string b = i.ToString();
            int digit = 0;
            foreach (char c in b)
            {
                switch (c)
                {
                    case '0': return false;
                    case '1': digit = 1;
                        break;
                    case '2': digit = 2;
                        break;
                    case '3': digit = 3;
                        break;
                    case '4': digit = 4;
                        break;
                    case '5': digit = 5;
                        break;
                    case '6': digit = 6;
                        break;
                    case '7': digit = 7;
                        break;
                    case '8': digit = 8;
                        break;
                    case '9': digit = 9;
                        break;
                }
                if (i % digit != 0)
                    return false;
            }
            return true;
    }
    
}
