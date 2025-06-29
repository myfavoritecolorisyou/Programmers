using System;

public class Solution {
    public string solution(string my_string, int[] index_list) {
        string answer = "";

        if ((my_string.Length >= 1 && my_string.Length <= 1000)
            && (index_list.Length >= 1 && index_list.Length <= 1000))
        {
            for (int i = 0; i < index_list.Length; i++)
            {
                if (char.IsLower(my_string[index_list[i]])
                    && (index_list[i] >= 0 && index_list[i] <= my_string.Length))
                {
                    answer += my_string[index_list[i]];
                }
            }
        }

        return answer;;
    }
}