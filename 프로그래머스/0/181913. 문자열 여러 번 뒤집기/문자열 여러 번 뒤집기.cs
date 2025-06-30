using System;

public class Solution {
    public string solution(string my_string, int[,] queries)
    {
        string answer = "";
        char[] char_array;

        if ((my_string.Length >= 1 && my_string.Length <= 1000)
            && queries.GetLength(0) >= 1 && queries.GetLength(0) <= 1000)
        {
            char_array = my_string.ToCharArray();
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int start = queries[i, 0];
                int end = queries[i, 1];
                while (start < end)
                {
                    char temp = char_array[start];
                    char_array[start] = char_array[end];
                    char_array[end] = temp;
                    start++;
                    end--;
                }
            }

            foreach (char c in char_array) answer += c;
        }

        return answer;
    }
}