using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        int[] answer = new int[] { };
        var temp = new List<int>();

        if ((s >= 0 && s <= 100)
            && (l >= 1 && l <= 8)
            && (k >= Math.Pow(10, l - 1) && k <= Math.Pow(10, l))
            && (intStrs.Length >= 1 && intStrs.Length <= 10000))
        {
            for (int i = 0; i < intStrs.Length; i++)
            {
                string str = intStrs[i];

                if (str.Length < s + l) continue;

                int num = 0;
                for (int j = 0; j < l; j++)
                {
                    num = num * 10 + (str[s + j] - '0');
                }

                if (num > k)
                {
                    temp.Add(num);
                }
            }
        }

        answer = temp.ToArray();
        return answer;
    }
}