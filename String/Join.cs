using System;

using System.Linq;
public class joint
{
	public static void Main1(string[] args)
	{
		int[] a = new int[5];
		Console.WriteLine("Enter Element");
		for (int i = 0; i < a.Length; i++)
		{
			a[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine(String.Join(" ", a));
		for (int i = 0; i < a.Length; i++)
		{
			for (int j = 0; j < a.Length; j++)
			{
				if (a[i] > a[j])
				{
					int temp = a[i];
					a[i] = a[j]; a[j] = temp;
				}
			}

		}
		Console.WriteLine("/////////////////////////");
		Console.WriteLine(String.Join(" ", a));
	}
}

public class joint1
{
	public static void Main1(string[] args)
	{
	}
}