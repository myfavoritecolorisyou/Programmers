using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        string[] answer = new string[] { };
        var temp_list = new List<string>();

        if ((todo_list.Length >= 1 && todo_list.Length <= 100)
            && todo_list.Distinct().Count() == todo_list.Length)
        {
            for (int i = 0; i < todo_list.Length; i++)
            {
                if ((todo_list[i].Length >= 2 && todo_list[i].Length <= 20)
                    && todo_list[i].All(char.IsLower)
                    && finished[i] != true)
                {
                    temp_list.Add(todo_list[i]);
                }
            }
        }
        answer = temp_list.ToArray();

        return answer;
    }
}