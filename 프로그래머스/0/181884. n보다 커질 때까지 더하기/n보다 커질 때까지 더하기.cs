using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        int temp_value = 0;

        if ((numbers.Length >= 1 && numbers.Length <= 100)
            && (n >= 0 && n < numbers.Sum()))
        {
            foreach (var number in numbers)
            {
                if ((number >= 1 && number <= 100))  
                    temp_value += number;

                if (temp_value > n) break;
            }
        }
        answer = temp_value;
        
        return answer;
    }
}