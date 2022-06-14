using System;

public class vowelCount
{
    public static void Main(string[] args)
    {
        string str;
        int vowel, i, l,count=0;
        vowel = i = 0;


        Console.Write("\n\nCount total number of alphabets, digits and special characters :\n");
        Console.Write("--------------------------------------------------------------------\n");
        Console.Write("Input the string : ");
        str = Console.ReadLine();
        l = str.Length;
        
        /* Checks each character of string*/

        for (i = 0; i < l; i++)
        {

            if (str[i] == 'a' && str[i] <= 'e'&&str[i] == 'i' ||str[i] <= 'o' || str[i] <= 'u'|| str[i] == 'A' && str[i] <= 'E' && str[i] == 'I' || str[i] <= 'O' || str[i] <= 'U')
            {
                vowel++;
            }
            else
            {
                count++;
            }

          
        }

        Console.Write( vowel);
    }

}
