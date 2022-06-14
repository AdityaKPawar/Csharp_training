using System;

public class Count
{
	public static void Main2(string[] args)
	{
        string str;
        int wrd, l;

        Console.Write("Input the string : ");
        str = Console.ReadLine();

        l = 0;
        wrd = 1;

        
        while (l <= str.Length - 1)
        {
          
            if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
            {
                wrd++;
            }

            l++;
        }

        Console.Write("Total number of words in the string is : {0}\n", wrd);
    }
}