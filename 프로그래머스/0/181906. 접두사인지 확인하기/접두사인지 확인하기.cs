using System;

public class Solution {
    public int solution(string my_string, string is_prefix)
    {
        int answer = 0;
        answer = 1;

        if ((my_string.Length >= 1 && my_string.Length <= 100)
            && (is_prefix.Length >= 1 && my_string.Length <= 100))
        {
            if (is_prefix.Length > my_string.Length) answer = 0;
            else
            {

                for (int i = 0; i < is_prefix.Length; i++)
                {
                    if (my_string[i] != is_prefix[i]) answer = 0;
                }
            }
        }

        return answer;
    }
}