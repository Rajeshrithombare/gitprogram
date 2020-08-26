using System;

namespace Swapnum24
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Program ob = new Program();

            Console.WriteLine("Enter first number");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            n2 = int.Parse(Console.ReadLine());

                    int temp = 0;
                    temp = n1;
                    n1 = n2;
                    n1 = temp;

            int r=ob.mymethod(n1);
            int v = ob.mymethod2(n2);

            Console.WriteLine("swap num= "+v);
            Console.WriteLine("swap num="+r);


        }
        public int mymethod(int b1)
        {
           
        
            return b1;
        }
        public int mymethod2(int b2)
        {
            
            return b2;
        }
    }
}
