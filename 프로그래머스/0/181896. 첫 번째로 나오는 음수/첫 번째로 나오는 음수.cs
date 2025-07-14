using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        answer = -1;

        //5 ≤ num_list의 길이 ≤ 100
        //- 10 ≤ num_list의 원소 ≤ 100
        if (num_list.Length >= 5 && num_list.Length <= 100)
        {
            for (int i = 0; i < num_list.Length; i++)
            {
                if ((num_list[i] >= -10 && num_list[i] <= 100)
                    && num_list[i] < 0)
                {
                    answer = i;
                    break;
                }
            }
        }

        return answer;
    }
}