using System;

namespace AssignArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int [5];
            int res = 0;
            int[] sum = new int[5];
            int i;
            Console.WriteLine("Enter array element");
            for(i=0;i<=4;i++)
            {
                Console.Write(i);
                a[i] = int.Parse(Console.ReadLine());

            }
            for(i=0;i<=4;i++)
            {
               

                res+= a[i];

                Console.WriteLine(res);
            }
          
      
            Console.ReadKey();

        }
    }
}
