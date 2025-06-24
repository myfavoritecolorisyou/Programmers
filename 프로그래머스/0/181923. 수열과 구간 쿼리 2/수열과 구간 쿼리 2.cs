using System;public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int[] answer = new int[queries.GetLength(0)];
        
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];
            int k = queries[i, 2];
            int minValue = int.MaxValue; // int가 가질 수 있는 가장 큰 정수값, minValue 초기화
            bool isFound = false;

            for (int j = s; j <= e; j++)
            {
                if (arr[j] > k)
                {
                    if (arr[j] < minValue)
                    {
                        minValue = arr[j];
                        isFound = true;
                    }
                }

                answer[i] = isFound ? minValue : -1;
            }
        }

        return answer;
    }
}