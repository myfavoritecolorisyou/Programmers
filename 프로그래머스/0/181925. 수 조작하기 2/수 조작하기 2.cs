using System;

public class Solution {
    public string solution(int[] numLog) {
        string answer = "";
        int element = 0;

        for (int i = 0; i < numLog.Length - 1; i++)
        {
            // 1. x + y = z
            // 2. -1 * (x - z) = y
            element = (numLog[i] - numLog[i + 1]) * -1;

            switch (element)
            {
                case 1:
                    answer += 'w';
                    break;
                case -1:
                    answer += 's';
                    break;
                case 10:
                    answer += 'd';
                    break;
                case -10:
                    answer += 'a';
                    break;
            }
        }

        return answer;
    }
}