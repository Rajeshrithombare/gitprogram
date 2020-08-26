using System;

namespace AssiRosh27_2
{
    //print password 1234 is correct other is wrong
    class Program
    {
        static void Main(string[] args)
        {
            int pas;

            Console.WriteLine("Enter the password");
            pas = int.Parse(Console.ReadLine());

            if(pas==1234)
            {
                Console.WriteLine("password is correct");
            }
            else
            {
                Console.WriteLine("password is wrong");
            }
            Console.ReadKey();
        }
    }
}
