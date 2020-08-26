using System;

namespace AssiRosh5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter two number");
            num = int.Parse(Console.ReadLine());

            for(int i=1;i<4;i++)
            {
                if(num<i)
                {
                    Console.WriteLine("this is Small Number"+num);
                }
                else if(num>i)
                {
                    Console.WriteLine("this is greter Number"+num);
                }

            }

            Console.ReadKey();
            
        }
    }
}
