using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        int answer = 0;

        if (is_suffix.Length > my_string.Length) return answer;

        for (int i = 0; i < is_suffix.Length; i++)
        {
            if (my_string[my_string.Length - is_suffix.Length + i] != is_suffix[i]) return answer;
        }

        answer = 1;
        return answer;
    }
}