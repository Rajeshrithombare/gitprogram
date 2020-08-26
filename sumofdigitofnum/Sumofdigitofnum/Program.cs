using System;

namespace Sumofdigitofnum
{
   public class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            string s;

            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            s = ob.mymethod(n);
            Console.WriteLine(s);

            Console.ReadKey();
        }
        public string mymethod(int num)
        {
            int i = 1;
            int k = 1;
            string str;
            while(i<num)
            {
                if(num%i==0)
                {
                    k++;
                    i++;
                }
                if (k == 2)
                {
                    str = "prime";
                }
                else
                {
                    str = "not prime";
                }
            }
            return str;
            

        }
       
    }
}
