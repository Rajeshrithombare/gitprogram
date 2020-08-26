using System;

namespace power
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            int n1, n2;

            Console.WriteLine("Enter two number");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            ob.mymethod(n1, n2);

            Console.ReadKey();
        }
        public int mymethod(int n1,int n2)
        {
            int a, b;
            a = n1;
            b = n2;
            int i;
            for ( i = 1; i<b; i++) 
            {
                a = a*b;
                
                

            }
            Console.WriteLine("Result is = "+a);
            return a;

        }
    }
}
