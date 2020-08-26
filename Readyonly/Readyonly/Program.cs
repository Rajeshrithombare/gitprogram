using System;

namespace Readyonly
{
    class sample
    {
        public readonly string cname="Raju";


        public sample()
        {
          
            Console.WriteLine("Call " + cname);
            cname = "abc";
        }
       
   
    }
    class Program
    {
         static void Main(string[] args)
        {
            sample ob = new sample();
            string str = ob.cname;
           
            Console.WriteLine("cname is " + str);
           
            Console.ReadKey();

        }
    }
}
