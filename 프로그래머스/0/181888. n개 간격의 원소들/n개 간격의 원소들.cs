using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[] { };
        var temp_list = new List<int>();

        if (num_list.Length >= 5 && num_list.Length < 20)
        {
            for (int i = 0; i < num_list.Length; i += n)
            {
                if (num_list[i] >= 1 && num_list[i] <= 9)
                    temp_list.Add(num_list[i]);
            }
        }

        answer = temp_list.ToArray();

        return answer;
    }
}