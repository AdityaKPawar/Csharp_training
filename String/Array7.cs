using System;

public class Class5
{
    //WAP to print reverse of an array.Also print every alternate element backwards.
    public static void Main7()
    {
        int[] no = { 25, 11, 7, 75, 56, 2 };
        int leng = no.Length;
        for (int i = leng - 1; i >= 0; i--)
        {
            Console.WriteLine(no[i]);
        }
    }
}