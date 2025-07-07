using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        // my_string은 영소문자로 이루어져 있습니다.
        // 1 ≤ m ≤ my_string의 길이 ≤ 1,000
        // m은 my_string 길이의 약수로만 주어집니다.
        // 1 ≤ c ≤ m
        string answer = "";

        if ((m >= 1 && m <= my_string.Length && my_string.Length <= 1000)
            && (my_string.Length % m == 0)
            && (c >= 1 && c <= m))
        {
            for (int i = 0; i < my_string.Length; i += m)
            {
                answer += my_string[i + c - 1];
            }
        }

        return answer;
    }
}