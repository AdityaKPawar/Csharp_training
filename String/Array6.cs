using System;

public class Class2
{
	public static void Main3(string[] args)
	{
        int[] no=new int[10];
       
        int no2 = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < no.Length; i++)
        {
            no[i] = Convert.ToInt32(Console.ReadLine());

            while (no2 == no[i])
            {
                Console.WriteLine(no2 + "present at no " + i + " th  index");
                break;
            }
        }       
    }
  
}
