using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[] { };
        var temp_array = new int[52];

        foreach (char c in my_string)
        {
            if (char.IsUpper(c))
            {
                temp_array[c - 'A']++;
            }
            else if (char.IsLower(c))
            {
                temp_array[c - 'a' + 26]++;
            }
        }

        answer = temp_array;

        return answer;
    }
}