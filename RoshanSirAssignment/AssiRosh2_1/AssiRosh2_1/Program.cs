using System;

namespace AssiRosh2_1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            float s = 0, i=3, j=2;
            Console.WriteLine("Enter the value");
            s = s + 1;
            while(i<=8)
            {
                s= s+i/j;
                Console.WriteLine("Division of :{0} \n i:{1}",i,j,s);
                i = i + 2;
                j = j*2;
            }
            Console.WriteLine("Division of := " +s);
            Console.ReadKey();
        }
    }
}
