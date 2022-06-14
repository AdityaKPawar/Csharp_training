using System;

public class Class1
{
    public static void Main2()
    {
        int[] no = new int[5];
        int[] no2 = new int[5];
        int[] no3 = new int[5];

        for (int i = 0; i < no.Length; i++)
        {

            no[i] = Convert.ToInt32(Console.ReadLine());

        }
        int j = 0;
        int k = 0;

        for (int i = 0; i < no.Length; i++)
        {
            if (no[i] % 2 == 0)
            {
                no2[j] = no[i];
                j++;
            }
            else
            {
                no3[k] = no[i];
                k++;
            }
        }
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("even no is" + no2[i]);
        }
        for (int i = 0; i < j; i++)
        {
            Console.WriteLine("odd no is" + no3[i]);
        }

    }
}
