using System;

public class Solution {
    public string solution(string[] arr) {
        string answer = "";

        if (arr.Length >= 1 && arr.Length <= 200)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                answer += arr[i];
            }
        }

        return answer;
    }
}