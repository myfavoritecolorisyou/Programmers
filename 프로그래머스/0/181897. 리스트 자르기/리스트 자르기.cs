using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int[] answer = new int[] { };
        if (slicer.Length == 3 &&
           num_list.Length >= 5 && num_list.Length <= 30 &&
           n >= 1 && n <= 4)
        {
            int a = slicer[0];
            int b = slicer[1];
            int c = slicer[2];

            
            if ((0 <= a && a <= b)
                && b <= num_list.Length - 1
                && (c >= 1 && c <= 3))
            {
                bool is_valid = true;
                foreach (int num in num_list)
                {
                    if (num < 0 || num > 100)
                    {
                        is_valid = false;
                        break;
                    }
                }

                if (is_valid)
                {
                    List<int> result = new List<int>();

                    switch (n)
                    {
                        case 1:
                            for (int i = 0; i <= b; i++)
                                result.Add(num_list[i]);
                            break;

                        case 2:
                            for (int i = a; i < num_list.Length; i++)
                                result.Add(num_list[i]);
                            break;

                        case 3:
                            for (int i = a; i <= b; i++)
                                result.Add(num_list[i]);
                            break;

                        case 4:
                            for (int i = a; i <= b; i += c)
                                result.Add(num_list[i]);
                            break;
                    }

                    answer = result.ToArray();
                }
            }
        }

        return answer;
    }
}