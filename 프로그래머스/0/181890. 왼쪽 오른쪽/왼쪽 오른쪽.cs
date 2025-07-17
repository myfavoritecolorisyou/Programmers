using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] str_list) {
        string[] answer = new string[] { };
        var temp_list = new List<string>();

        if (str_list.Length >= 1 && str_list.Length <= 20)
        {
            for (int i = 0; i < str_list.Length; i++)
            {
                if (str_list[i] == "l")
                {
                    for (int j = 0; j < i; j++)
                    {
                        temp_list.Add(str_list[j]);
                    }

                    break;
                }
                else if (str_list[i] == "r")
                {
                    for (int j = i + 1; j < str_list.Length; j++)
                    {
                        temp_list.Add(str_list[j]);
                    }

                    break;
                }
            }

            answer = temp_list.ToArray();
        }

        return answer;
    }
}