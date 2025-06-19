using System;
using System.Linq;

public class Solution {
    public string solution(string str1, string str2) {
            string answer = "";
            bool hasUpper_str1 = str1.Any(char.IsUpper);
            bool hasUpper_str2 = str2.Any(char.IsUpper);

            if ((!hasUpper_str1 && !hasUpper_str2) && str1.Length == str2.Length)
            {
                char[] result = new char[str1.Length * 2];
                for (int i = 0; i < str1.Length; i++)
                {
                    result[i * 2] = str1[i];
                    result[(i * 2) + 1] = str2[i];
                }

                answer = new string(result);
            }
            return answer;
    }
}