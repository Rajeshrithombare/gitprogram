using System;

namespace Febonaciass24
{
   public class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            int num;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());
            ob.mymethod(num);
         
            Console.ReadKey();
        }
        public int mymethod(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write(a);
            Console.Write(b);
            while(c<n)
            {
                c = a + b;
                a = b;
                b = c;

                Console.Write(c);           
          }
            
           return 0;
        }
    }
}
