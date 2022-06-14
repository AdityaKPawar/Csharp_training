using System;

public class String
{
	public static void Main1(string[] args)
	{
		string str = "    ADiTya";
		int count = 0;

		for (int i = 0; i < str.Length; i++)
		{
			char c = str[i];
			if (c >= 'A'&& c<='Z')
				count++;
			if(c >= 'a'&& c<='z')
			{ }
		}
		Console.WriteLine(count);
	  
		
	}

    internal static bool Join(string v, int[] a)
    {
        throw new NotImplementedException();
    }
}
