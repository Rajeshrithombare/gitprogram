using System;

namespace PaternStar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1;i<4;i++)
            {

                Console.WriteLine("*");
            }
           
            for (int sp=1;sp>2;sp--)
            {
                Console.WriteLine(sp);
                
                if(sp==5)
                {
                    Console.WriteLine("*");
                }
                for (i = 1+1; i < 4; i++)
                {

                    Console.WriteLine("*");
                }
            }
          
            Console.ReadKey();
        }
    }
}
