using System;

namespace call_by_value
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine(sum);
            //                int a = 2, b = 3;
            sum =Method();
           
            Console.ReadKey();

        }
        static int Method(   )
        {
            int res=5;
            //res = c + d;
            return res;
            
        }
    }
}
