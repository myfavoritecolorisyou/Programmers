using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;

        if (a >= 1 && b < 10000)
        {
            string combined1 = $"{a}{b}";
            string combined2 = $"{b}{a}";

            int num1 = int.Parse(combined1);
            int num2 = int.Parse(combined2);

            answer = Math.Max(num1, num2);
        }

        return answer;
    }
}