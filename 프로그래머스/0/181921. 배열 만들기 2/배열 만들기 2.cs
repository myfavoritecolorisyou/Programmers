using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        int[] answer = new int[] { };
        var temp_array = new List<int>();
        
        for (int  i = l ; i <= r; i++)
        {
            int value = i;

            string binary_string = value.ToString();
            bool is_binary = true;

            foreach (var ch in binary_string)
            {
                if (ch != '0' && ch != '5')
                {
                    is_binary = false;
                    break;
                }
            }

            if (is_binary)
            {
                temp_array.Add(value);
            }
        }

        if (temp_array.Count == 0)
            temp_array.Add(-1);

        answer = temp_array.ToArray();

        return answer;
    }
}