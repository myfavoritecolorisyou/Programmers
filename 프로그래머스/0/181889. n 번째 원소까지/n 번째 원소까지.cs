using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[] { };
        var temp_list = new List<int>();

        if ((num_list.Length >= 2 && num_list.Length <= 30)
            && (n >= 1 && n <= num_list.Length))
        {
            for (int i = 0; i < n; i++)
            {
                if (num_list[i] >= 1 && num_list[i] <= 9)
                    temp_list.Add(num_list[i]);
            }

            answer = temp_list.ToArray();
        }

        return answer;
    }
}