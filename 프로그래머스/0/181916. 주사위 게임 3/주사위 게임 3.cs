using System;
using System.Linq;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;

        var dice_number = new[] { a, b, c, d };
        var freq = dice_number.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

        switch (freq.Count)
        {
            case 1:
                answer = int.Parse($"{a}{b}{c}{d}");
                break;
            case 2:
                if (freq.Any(k => k.Value ==3))
                {
                    int p = freq.First(k => k.Value == 3).Key;
                    int q = freq.First(k => k.Value == 1).Key;
                    answer = (int) Math.Pow(10 * p + q, 2);
                }
                else
                {
                    var keys = freq.Keys.ToList();
                    answer = (keys[0] + keys[1]) * Math.Abs(keys[0] - keys[1]);
                }
                break;
            case 3:
                var singles = freq.Where(k => k.Value == 1).Select(k => k.Key).ToArray();
                answer = singles[0] * singles[1];
                break;
            case 4:
                answer = dice_number.Min();
                break;
            default:
                return answer = 0;
        }

        return answer;
    }
}