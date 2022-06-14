using System;

public class Uppercase
{
	public static void Main1()
	{
		string str="AdityA";		
		for(int i=0;i<str.Length;i++)
			if(char.IsUpper(str[i]))
            {
				Console.WriteLine(char.ToLower(str[i]));
            }
		else if(char.IsLower(str[i]))

			{
			Console.WriteLine(char.ToUpper(str[i]));
		}
	}
}
