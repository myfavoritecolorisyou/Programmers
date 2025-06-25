using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start_num, int end_num)
    {
        int[] answer = new int[] { };
        var temp_list = new List<int>();

        if (start_num >= 0 
            && start_num <= end_num 
            && end_num <= 50)
        {
            for (int i = start_num; i <= end_num; i++)
            {
                temp_list.Add(i);
            }
        }

        answer = temp_list.ToArray();
        return answer;
    }
}