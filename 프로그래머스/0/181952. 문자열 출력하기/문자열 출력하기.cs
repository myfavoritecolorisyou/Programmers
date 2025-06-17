using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        
        s = Console.ReadLine();
        if (s.Length >= 1 && s.Length < 10000000) {
            Console.WriteLine(s);
        }
    }
}