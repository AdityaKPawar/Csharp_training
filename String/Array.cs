using System;

public class Array
{
	public static void Main2(string[] args)
	{
		int[] no = { 10, 25, 45, 85, 96, 74, 325, 47 };
		int[] no2 = new int[no.Length];
		for (int i = 0; i < no.Length; i++)
        {
			no2[i] = no[i];
        }
		for (int i = 0; i < no2.Length; i++)
        {
			Console.WriteLine(no2[i]);
        }
		for (int i = 0; i < no.Length; i++)
        {
			Console.WriteLine("Original will be {0}",no[i]);
        }

	}
}
