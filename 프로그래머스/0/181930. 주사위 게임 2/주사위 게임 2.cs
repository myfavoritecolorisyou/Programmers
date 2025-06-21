using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b, int c)
    {
        int[] numbers = { a, b, c };
        var counts = numbers.GroupBy(n => n)
                            .ToDictionary(g => g.Key, g => g.Count());

        int sum = numbers.Sum();
        int squareSum = numbers.Sum(n => n * n);
        int cubeSum = numbers.Sum(n => n * n * n);

        if (counts.Values.Any(v => v == 3))
            return sum * squareSum * cubeSum;
        else if (counts.Values.Any(v => v == 2))
            return sum * squareSum;
        else
            return sum;
    }
}