using System;

//10.	WAP to find the maximum and minimum value in an array.
internal class MaxMinArray
{
    public static void Main5()
    {
        int[] no = { 10, 55, 8, 3, 5 };
        int len = no.Length;
        int max = no[0];
        for (int i = 1; i < len; i++)
        {

            if (max < no[i])
            {
                max = no[i];

            }
        }
        Console.WriteLine(max);
    }
}