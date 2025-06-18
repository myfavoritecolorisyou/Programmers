using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        if (a >= 1 && b <= 100)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
    }
}