using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] names) {
        string[] answer = new string[] { };
        var temp_list = new List<string>();

        if (names.Length >= 5 && names.Length <= 30)
        {
            for (int i = 0; i < names.Length; i += 5)
            {
                if (names[i].Length >= 1 && names[i].Length <= 10)
                {
                    temp_list.Add(names[i]);
                }
            }
        }

        answer = temp_list.ToArray();

        return answer;
    }
}