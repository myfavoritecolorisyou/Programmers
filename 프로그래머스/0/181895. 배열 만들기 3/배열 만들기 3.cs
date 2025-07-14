using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        int[] answer = new int[] { };
        var list = new List<int>();
        int a1 = intervals[0, 0];
        int b1 = intervals[0, 1];
        int a2 = intervals[1, 0];
        int b2 = intervals[1, 1];

        //1 ≤ arr의 길이 ≤ 100,000
        //1 ≤ arr의 원소< 100
        //1 ≤ a1 ≤ b1<arr의 길이
        //1 ≤ a2 ≤ b2<arr의 길이

        if ((arr.Length > 1 && arr.Length <= 100000)
            && (a1 >= 1 && a1 <= b1 && b1 < arr.Length)
            // && (a2 >= 1 && a2 <= b2 && b2 < arr.Length)) // ??
            && (a2 >= 0 && a2 <= b2 && b2 < arr.Length))
        {
            for (int i = a1; i <= b1; i++)
            {
                list.Add(arr[i]);
            }

            for (int i = a2; i <= b2; i++)
            {
                list.Add(arr[i]);
            }
        }

        answer = list.ToArray();

        return answer;
    }
}