using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
            string answer = "";
            var result = my_string.ToCharArray();

            for (int i = s; i < overwrite_string.Length + s; i++)
            {
                result[i] = overwrite_string[i - s];
            }

            answer = new string(result);

            return answer;
    }
}