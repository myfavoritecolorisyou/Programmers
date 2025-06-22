using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = 0;
        answer = n;

        if ((n >= -100000 && n <= 100000)
            && (control.Length >= 1 && control.Length <= 100000))
        {
            foreach (char c in control.ToCharArray())
            { 
                switch (c)
                {
                    case 'w': 
                        answer += 1; 
                        break;
                    case 's':
                        answer -= 1;
                        break;
                    case 'd':
                        answer += 10;
                        break;
                    case 'a':
                        answer -= 10;
                        break;
                }
            }
        }

        return answer;
    }
}