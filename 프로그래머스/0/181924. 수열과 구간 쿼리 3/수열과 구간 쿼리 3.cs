using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[] { };
        int temp = 0;
        answer = (int[]) arr.Clone();

        if ((arr.GetLength(0) >= 1 && arr.GetLength(0) <= 1000)
            && (queries.GetLength(0) >= 1 && queries.GetLength(0) <= 1000))
        {
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                temp = answer[queries[i, 0]];
                answer[queries[i, 0]] = answer[queries[i, 1]];
                answer[queries[i, 1]] = temp;
            }
        }

        return answer;
    }
}