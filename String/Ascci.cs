using System;

public class Ascci
{
	public static void Main2()
	{
		char cha;
		cha = Convert.ToChar(Console.ReadLine());

		Console.WriteLine(cha + (Convert.ToInt32(cha)));
	}
	}

public class prime
{
	public static void Main1()
	{
		int n,m=0;
		int flag = 0;
		n=Convert.ToInt32(Console.ReadLine());
		m = n / 2;
		for(int i = 2; i <= m; i++)
			if(n % i == 0)
            {
				Console.WriteLine("not prime");
				flag = 1;
            }
		if (flag == 0)
			Console.WriteLine(" prime");
	}
}
//namespace first
//{ 
//public class Emp
//{
//	public virtual void firstmethode()
//	{
//			Console.WriteLine("Employee");
//	}
//}
//	public class Manager:Emp
//    {
//		public override void firstmethode()
//        {
//			Console.WriteLine("Manager");
//        }

//	}
//	class program
//    {
//		public static void Main(string[] args)
//        {
//			Manager M1 = new Manager();
//			M1.firstmethode();
//			Emp E1 = new Emp();
//			E1.firstmethode();
//			Emp E2 = new Manager();
//			E2.firstmethode();


//		}
//    }
//}

//namespace first
//{
//	public class Emp
//	{
//		public void firstmethode()
//		{
//			Console.WriteLine("Employee");
//		}
//	}
//	public class Manager : Emp
//	{
//		public new void firstmethode()
//		{
//			Console.WriteLine("Manager");
//		}

//	}
//	class program
//	{
//		public static void Main(string[] args)
//		{
//			Manager M1 = new Manager();
//			M1.firstmethode();
//			Emp E1 = new Emp();
//			E1.firstmethode();
//			Emp E2 = new Manager();
//			E2.firstmethode();


//		}
//	}
//}

public class Anagram
{
	public static void Main1(string[] args)
    {
		Console.WriteLine("Enter a string");
		string str1=Console.ReadLine();
		Console.WriteLine("Enter a string");
		string str2 = Console.ReadLine();

		string s1=str1.ToLower();
		string s2=str2.ToLower();

		char[] ch1 = s1.ToCharArray();
		char[] ch2 = s2.ToCharArray();

  //       Array.Sort(ch1);
		//Array.Sort(ch2);

		//Console.WriteLine(String.Join(" ", ch1));

		//String st1 = new String(ch1);

	}

}

public class Max
{
	public static void Main1(string[] args)
    {
		int[] arr = { 1, -2, -5, 5, 8, -3, 4 };
		for(int i=0; i<arr.Length; i++)
        {
			if(arr[i]>0)
            {
				arr[i]=arr[i]*arr[i];
            }
			Console.WriteLine(arr[i]);
        }
    }
}


public class Max1
{
	public static void Main1(string[] args)
	{
		int[,] a = new int[,] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 11, 12, 13, 14, 15 } };
		for (int i = 0; i < a.GetLength(0); i++)
		{
			for (int j = 0; j < a.GetLength(1); j++)
			{
				if (i == 0 || j == 0 || i == a.GetUpperBound(0) || j == a.GetUpperBound(1))
				{
					Console.Write(a[i, j] +" ");
				}
				Console.WriteLine("");
			}
			Console.WriteLine();
		}
	}
}

public class sum
{
	public static void Main1(string[] args)
	{
		int[,] a = new int[,] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 11, 12, 13, 14, 15 } };
		for (int i = 0; i < a.GetLength(0); i++)
		{
			int sum = 0;
			for (int j = 0; j < a.GetLength(1); j++)
			{
				sum=sum+a[i,j];
			}
			Console.WriteLine("sum "+sum);
		}
	}
}

//using System.Linq;
//public class joint
//{
//	public static void Main1(string[] args)
//	{
//		int[] a = new int[5];
//		Console.WriteLine("Enter Element");
//		for (int i = 0; i < a.Length; i++)
//		{
//			a[i] = Convert.ToInt32(Console.ReadLine());
//		}
//		Console.WriteLine(String.Join(" ", a));
//			for (int j = 0; j < a.Length; j++)
//			{
//				sum = sum + a[i, j];
//			}
//			Console.WriteLine("sum " + sum);
//		}
//	}
//}

