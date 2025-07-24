using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        var temp_list = new List<int>();

        if (arr.Length >= 1 && arr.Length <= 1000000)
        {
            foreach (var t in arr)
            {
                if (t >= 1 && t <= 100)
                {
                    if (t >= 50 && t % 2 == 0)
                    {
                        temp_list.Add(t/2);
                    }
                    else if (t < 50 && t % 2 == 1)
                    {
                        temp_list.Add(t*2);
                    }
                    else
                    {
                        temp_list.Add(t);
                    }
                }
            }
        }

        answer = temp_list.ToArray();
        
        return answer;
    }
}