using System;


namespace Training_BasicDemo_Day1
{
    internal class Revision_Anagram
    {
        public static void Main1()
        {
         

            Console.WriteLine("Enter the 1st string");
            string str1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the 2nd string");
            string str2 = Console.ReadLine().ToLower();
            int count = 0;
            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    count = 0;
                    for (int j = 0; j < str2.Length; j++)
                    {
                        if (str1[i] == str2[j])

                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 1)
                        continue;
                    else
                    {
                        Console.WriteLine("string is not Anagram");
                        break;
                    }

                }
                if (count == 1)
                    Console.WriteLine("string is Anagram");
            }
            else
            {
                Console.WriteLine("string is not Anagram");
            }
        }
    }
}
