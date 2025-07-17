using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int even_num = 0;
        int odd_num = 0;

        for (int i = 0; i < num_list.Length; i++)
        {
            if (i % 2 == 0)
            {
                odd_num += num_list[i];
                continue;
            }

            if (i % 2 == 1)
            {
                even_num += num_list[i];
                continue;
            }
        }

        answer = even_num >= odd_num ? even_num : odd_num;

        return answer;
    }
}