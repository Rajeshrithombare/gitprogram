using System;

namespace Stringspace21
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Program ob = new Program();
            Console.WriteLine("Enter the string Element");
            String s = Console.ReadLine();
            int n=ob.mymethod(s);
            Console.ReadKey();
        }
       public int mymethod(string s)
        {

            int a = 0;
            for (int i = 0; i < s.Length; i++)
            {


                if (s[i] == ' ')

                {
                    a++;
                }

                
            }
            Console.WriteLine("spa=" + a);
            return a;

      





        }
        
    }

}
