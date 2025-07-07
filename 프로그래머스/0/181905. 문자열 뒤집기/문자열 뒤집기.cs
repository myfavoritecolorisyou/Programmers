using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";

        if ((my_string.Length >= 1 && my_string.Length <= 1000)
            && (s >= 0 && e >= s && e <= my_string.Length))
        {
            for (int i = 0; i < s; i++)
            {
                answer += my_string[i];
            }

            for (int i = e; i >= s; i--)
            {
                answer += my_string[i];
            }

            for (int i = e + 1; i < my_string.Length; i++)
            {
                answer += my_string[i];
            }
        }

        return answer;
    }
}