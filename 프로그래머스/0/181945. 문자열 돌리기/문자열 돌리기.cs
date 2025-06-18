using System;
using System.Text;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        var s_length = s.Length;
        if (s_length >= 1 && s_length <= 10)
        {
            for (int i = 0; i < s_length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}