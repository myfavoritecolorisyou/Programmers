using System;

public class Solution {
    public string solution(int q, int r, string code)
    {
        //0 ≤ r < q ≤ 20
        //r<code의 길이 ≤ 1,000
        //code는 영소문자로만 이루어져 있습니다.
        string answer = "";

        if (r >= 0 && r < q && q <= 20
            && r < code.Length)
        {
            for (int i = r; i < code.Length; i += q)
            {
                answer += code[i];
            }
        }

        return answer;
    }
}