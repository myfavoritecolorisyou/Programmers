using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

if (s.Length >= 1 && s.Length <= 20)
{
    var char_array = s.ToCharArray();
    for (int i = 0; i < s.Length; i++)
    {
        if (char.IsUpper(s[i])) char_array[i] = char.ToLower(s[i]);
        else char_array[i] =  char.ToUpper(s[i]);
    }

    var restored = new string(char_array);

    Console.WriteLine(restored);
}
    }
}