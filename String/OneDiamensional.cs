using System;
public class Class7
{
    public static void Main7()
    {

        int[] no=new int[5];
        int leng = no.Length;
        for (int i = 0; i < 5; i++)
        {
            no[i] = Convert.ToInt32(Console.ReadLine());
         
        }
        foreach(int i in no)
        {
            Console.WriteLine(i);
        }
    }
}