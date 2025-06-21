using System;
using System.Linq;

public class Solution {
    public int solution(int a, int d, bool[] included) {
        int answer = 0;

        if ((a >= 1 && a <= 100) 
            && (d >= 1 && d <= 100) 
            && (included.Length >= 1 && included.Length <= 100 && included.Contains(true)))
        {
            int temp = a;

            foreach (bool isTrue in included)
            {
                if (isTrue)
                {
                    answer += temp;
                }

                temp += d;
            }
        }

        return answer;
    }
}