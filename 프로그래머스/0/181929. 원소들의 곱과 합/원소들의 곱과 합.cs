using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int squared_value = num_list[0];
        int total_sum = num_list[0];

        if ((num_list.Length >= 2 && num_list.Length <= 10))
        {
            for (int i = 1; i < num_list.Length; i++)
            {
                if (num_list[i] >= 1 &&  num_list[i] <= 9)
                {
                    squared_value *= num_list[i];
                    total_sum += num_list[i];
                }
            }

            if (squared_value > total_sum * total_sum) answer = 0;
            else answer = 1;
        }

        return answer;
    }
}