using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";

        if ((my_string.Length >= 1 && my_string.Length <= 1000)
            && (n >= 1 && n <= my_string.Length))
        {
            for (int i = 0; i < n; i++)
            {
                answer += my_string[i];
            }
        }

        return answer;
    }
}