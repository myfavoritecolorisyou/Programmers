using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        string even_sum = "";
        string odd_sum = "";

        if ((num_list.Length >= 2 && num_list.Length <= 10))
        {
            foreach (int num in num_list)
            {
                if (num % 2 == 0) even_sum += num;
                else odd_sum += num;
            }

            answer = int.Parse(even_sum) + int.Parse(odd_sum);
        }

        return answer;
    }
}