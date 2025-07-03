using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] { };

        var list = new List<string>();

        for (int i = 0; i < my_string.Length; i++)
        {
            list.Add(my_string.Substring(i));
        }

        int n = list.Count;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (list[j].CompareTo(list[j + 1]) > 0)
                {
                    string temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }

        answer = list.ToArray();
        return answer;
    }
}