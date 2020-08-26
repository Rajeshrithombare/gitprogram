using System;

namespace Usetrycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Number is" + i);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e);

            }
            catch(DivideByZeroException caught)
            {
                Console.WriteLine(caught.Message);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Code reach till the end");
            }

        }
    }
}
