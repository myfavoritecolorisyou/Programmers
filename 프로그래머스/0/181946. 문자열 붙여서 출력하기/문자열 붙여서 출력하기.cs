using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        String s2 = input[1];
        
        if (s1.Length >= 1 && s2.Length <= 10)
        {
            Console.WriteLine(s1+s2);
        }
    }
}