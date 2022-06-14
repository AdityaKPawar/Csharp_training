using System;
using System.Text;

public class Palindrom
{
    static void Main1(string[] args)
    {
        String s,s1;
        Console.WriteLine(" Enter string");
        s = Console.ReadLine();
        Console.WriteLine(" Enter string");
        s1 = Console.ReadLine();

        String str = s.ToString();
        String str1 = s1.ToString();
        Console.WriteLine(str.CompareTo(str1));
    }
}
