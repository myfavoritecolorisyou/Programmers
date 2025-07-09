using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k) {
        int[] answer = new int[] { };
        var temp_array = new List<int>();

        //1 ≤ n ≤ 1,000,000
        //1 ≤ k ≤ min(1, 000, n)

        if ((n >= 1 && n <= 1000000)
            && (k >= 1 && k <= Math.Min(1000, n)))
        {
            for (int i = k; i <= n; i += k)
            {
                temp_array.Add(i);
            }
        }
        
        answer = temp_array.ToArray();

        return answer;
    }
}