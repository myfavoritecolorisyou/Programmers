using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int k) {
        string answer = "";
        bool hasUpper = my_string.Any(char.IsUpper);

        if ((my_string.Length >= 1 && my_string.Length <= 100)
            && !hasUpper
            && (k >= 1 && k <= 100))
        {
            for (int i = 0; i < k; i++)
            {
                answer += my_string;
            }
        }

        return answer;
    }
}