using System;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";

        if (my_strings.Length >= 1 
            && my_strings.Length == parts.GetLength(0)
            && parts.GetLength(0) <= 100)
        {
            for (int i = 0; i < my_strings.Length; i++)
            {
                if (my_strings[i].Length >= 1 && my_strings[i].Length <= 100)
                {
                    for (int j = parts[i, 0];  j <= parts[i, 1]; j++)
                    {
                        answer += my_strings[i][j];
                    }
                }
            }
        }

        return answer;
    }
}