using System;

public class Array2
{
	public static void Main11()
	{
        int[] no = new int[10];
        int[] no2= new int[5];
        int avg = 0;
        int result = 0;
        no[5]=no2[0];
            no[6] = no2[1];
            no[7] = no2[2];
            no[8] = no2[3];
            no[9] = no2[4];
        for (int i = 0; i < no.Length; i++)
        {
            no[i] = Convert.ToInt32(Console.ReadLine());
            avg = avg + no[i];



        }
            for (int j = 0; j < no2.Length; j++)
                Console.WriteLine(no2[j]);
            result = avg / no.Length;
            Console.WriteLine("Size" + no.Length);
            Console.WriteLine("Avg" + result);
        

    }
}
