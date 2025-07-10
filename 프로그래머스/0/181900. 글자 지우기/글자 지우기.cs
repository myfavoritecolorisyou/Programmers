using System;

public class Solution {
    public string solution(string my_string, int[] indices)
    {
        string answer = "";
        char[] char_array = my_string.ToCharArray();
        Array.Sort(indices);

        if ((indices.Length >= 1 && indices.Length <= 100))
        {
            foreach (var index in indices)
            {
                if (index >= 0 && index <= my_string.Length)
                    char_array[index] = '\0';
            }
        }

        answer = new string(char_array).Replace("\0", "");

        return answer;
    }
}