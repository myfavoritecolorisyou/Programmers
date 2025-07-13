using System;

public class Solution {
    public int solution(int[] arr, int idx) {
        int answer = 0;
        //3 ≤ arr의 길이 ≤ 100'000
        //arr의 원소는 전부 1 또는 0입니다.

        answer = -1;

        for (int i = idx; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                answer = i;
                break;
            }
        }

        return answer;
    }
}