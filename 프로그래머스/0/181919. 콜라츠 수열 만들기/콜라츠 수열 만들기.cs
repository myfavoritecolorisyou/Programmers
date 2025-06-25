using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] { };
        var temp_list = new List<int>();
        var value = n;

        if (value >= 1 && value <= 1000)
        {
            temp_list.Add(value);
            while (value > 1)
            {
                if (value % 2 == 0)
                {
                    value /= 2;
                }
                else
                {
                    value = 3 * value + 1;
                }
                temp_list.Add(value);
            }
        }
        else
        {
            temp_list.Add(value);
        }

        answer = temp_list.ToArray();
        return answer;
    }
}