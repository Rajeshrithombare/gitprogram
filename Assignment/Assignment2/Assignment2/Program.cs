using System;

namespace Assignment2
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            string str = Console.ReadLine();
            Program ob = new Program();
            string name = ob.method(str);
            Console.WriteLine(name);
            Console.ReadKey();

        }
        public string method(string s)
        {
            Console.WriteLine("Wellcome friends!"+s);
            string str = "have nice day";
            return str;
        }
    }
}
