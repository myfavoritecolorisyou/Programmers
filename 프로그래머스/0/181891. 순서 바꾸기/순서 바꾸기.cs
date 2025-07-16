using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[] { };
        var temp_queue = new Queue<int>();

        if ((num_list.Length >= 2 && num_list.Length <= 30)
            && (n >= 1 && n <= num_list.Length))
        {
            for (int i = n; i < num_list.Length; i++)
            {
                if (n >= 1 && n <= num_list.Length)
                    temp_queue.Enqueue(num_list[i]);
            }

            for (int i = 0; i < n;  i++)
            {
                if (n >= 1 && n <= num_list.Length)
                    temp_queue.Enqueue(num_list[i]);
            }
        }

        answer = temp_queue.ToArray();

        return answer;
    }
}