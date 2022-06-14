using System;

public class SortOrder
{
	public static void Main2()
	{
		int[] arr = { 1, 2, 3, 4, 5, 6, };
        int temp;

    
        for (int i = 0; i < arr.Length - 1; i++)

            
            for (int j = i + 1; j < arr.Length; j++)

                if (arr[i] < arr[j])
                {

                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

       
        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
    }
}
