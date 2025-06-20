using System;

public class Solution {
    public int solution(int a, int b, bool flag) {
        int answer = 0;

        if (a >= -1000 && a <= 1000
            && b >= -1000 && b <= 1000)
        {
            if (flag) answer = a + b;
            else answer = a - b;
        }

        return answer;
    }
}