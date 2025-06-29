using System;
using System.Linq;

public class Solution {
    public int solution(string number) {
        bool isValid = (number.Length >= 1 && number.Length <= 100000)
               && number.All(char.IsDigit)
               && (number == "0" || number[0] != '0');

        int answer = 0;
        int total_sum = 0;

        if (isValid)
        {
            for (int i = 0; i < number.Length; i++)
            {
                total_sum += number[i] - '0';
            }

            answer = total_sum % 9;
        }

        return answer;
    }
}