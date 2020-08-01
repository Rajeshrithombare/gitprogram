using System;

namespace array_method
{
    class Program
    {
        //4. With argument and with return type

        static void Main(string[] args)
        {
            int[] a = new int[4];
            int[] b = new int[4];
            int[] r = new int[4];
            int i;
            Console.WriteLine("enter first array element: ");
            for (i = 0; i <= 3; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter second array element: ");
            for (i = 0; i <= 3; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            r = method(a,b);
            for (i = 0; i <= 3; i++)                                                                  
            {
                Console.WriteLine(r[i]);
            }

            Console.ReadKey();
        }
        static int[] method( int[]arr1, params int []arr2)
        {
            int i;
            int[] result = new int[4];
           
            Console.WriteLine("addittion of arrays are: ");
            for (i = 0; i <= 3; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }
    } 
}
