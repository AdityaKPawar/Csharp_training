using System;

public class Sort2
{
	public static void Main1()
	{
		int[] arr = new int[] { 1, 2, 3, 4, 5};
		int temp;

		for(int i = 0; i < arr.Length-1; i++)
       
				for(int j =i+1; j < arr.Length; j++)
            
				if (arr[i] > arr[j])
				{
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
				foreach(int k in arr)
					Console.Write(k+" ");
            }
	}

