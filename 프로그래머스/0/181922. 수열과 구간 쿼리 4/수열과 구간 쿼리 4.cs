using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries)
    {
        int[] answer = new int[] { };
        answer= (int[])arr.Clone();

        if ((arr.Length >= 1 && arr.Length <= 1000)
            && (queries.GetLength(0) >= 1 && queries.GetLength(0) <= 1000))
        {
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int s = queries[i, 0];
                int e = queries[i, 1];
                int k = queries[i, 2];

                for (int j = s; j <= e; j++)
                {
                    if ((j % k == 0) 
                        && (arr[j] >= 0 && arr[j] <= 1000000))
                    {
                        answer[j]++;
                    }
                }
            }
        }

        return answer;
    }
}