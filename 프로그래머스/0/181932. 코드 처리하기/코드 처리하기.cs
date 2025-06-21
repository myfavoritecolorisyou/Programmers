using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        int mode = 0;

        for (int i = 0; i < code.Length; i++)
        {
            if (code[i] == '1')
            {
                mode = 1 - mode;
                continue;
            }

            if (mode == 0 && i % 2 == 0) answer += code[i];
            else if (mode == 1 && i % 2 == 1) answer += code[i];
        }

        return answer.Length == 0 ? "EMPTY" : answer;
    }
}