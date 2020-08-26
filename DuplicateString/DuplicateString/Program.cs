using System;

namespace DuplicateString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i, j, size, a = 0;
            Console.WriteLine("Enter string size");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value");
            for(i=0;i<=size;i++)
            {
               n = Convert.ToInt32(Console.ReadLine());
                i = Convert.ToInt32(Console.ReadLine());
                //n[i] =Convert.ToInt32( Console.ReadLine());
                j = Convert.ToInt32(Console.ReadLine());

            }
            for(i=0;i<=size;i++)
            {
                for(j=i+1;j<=size;j++)
                {
                    if(i==j)
                    {
                        a++;
                    }
                }
            }
      }
    }
}
