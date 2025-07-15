using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] { };
        var temp_list = new List<int>();
        int start_index = 0;
        int end_index = 0;

        if (arr.Length >= 1 && arr.Length <= 100000)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                {
                    start_index = i;
                    break;
                }
            }

            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] == 2)
                {
                    end_index = i;
                    break;
                }
            }

            if (start_index != 0 && end_index == 0)
            {
                temp_list.Add(2);
            }
            else if (start_index == 0 && end_index == 0)
            {
                temp_list.Add(-1);
            }
            else
            {
                for (int i = start_index; i <= end_index; i++)
                {
                    temp_list.Add(arr[i]);
                }
            }

        }

        answer = temp_list.ToArray();

        return answer;
    }
}