using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] stk = new int[] { };
        var temp_list = new List<int>();

        if (arr.Length >= 1 && arr.Length <= 100000)
        {
            int i = 0;
            while (i < arr.Length)
            {
                if (temp_list.Count == 0)
                {
                    temp_list.Add(arr[i]);
                    i++;
                }
                else if (temp_list[temp_list.Count - 1] < arr[i])
                {
                    temp_list.Add(arr[i]);
                    i++;
                }
                else
                {
                    temp_list.RemoveAt(temp_list.Count - 1);
                }
            }
        }

        stk = temp_list.ToArray();

        return stk;
    }
}