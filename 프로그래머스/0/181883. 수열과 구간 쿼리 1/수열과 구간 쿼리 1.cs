using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[] {};
        answer = (int[])arr.Clone();
        int[] difference_array = new int[arr.Length + 1];

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int start = queries[i, 0];
            int end = queries[i, 1];

            difference_array[start] += 1;
            if (end + 1 < difference_array.Length)
                difference_array[end + 1] -= 1;
        }

        int increment = 0;
        for (int i = 0; i < answer.Length; i++)
        {
            increment += difference_array[i];
            answer[i] += increment;
        }
        
        return answer;
    }
}