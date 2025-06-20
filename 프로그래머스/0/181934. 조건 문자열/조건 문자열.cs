using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        int answer = 0;
        switch (ineq + eq)
        {
            case ">=":
                if (n >= m) answer = 1;
                else answer = 0;
                break;
            case "<=":
                if (n <= m) answer = 1;
                else answer = 0;
                break;
            case "<!":
                if (n < m) answer = 1;
                else answer = 0;
                break;
            case ">!":
                if (n > m) answer = 1;
                else answer = 0;
                break;
            default:
                answer = 0;
                break;
        }

        return answer;
    }
}