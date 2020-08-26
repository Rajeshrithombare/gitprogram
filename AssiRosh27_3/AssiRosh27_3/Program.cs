using System;

namespace AssiRosh27_3
{
    class Program
    {
        //finding the 4 quadrent
        static void Main(string[] args)
        {
            float x, y;

            Console.WriteLine("Enter the quadrent");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("this is the first quadrent");
            }
            else if(x>0 && y<0)
            {
                Console.WriteLine("this is second quadrent");
            }
            else if(x<0 && y<0)
            {
                Console.WriteLine("this is therd quadrent");
            }
            else if(x<0 && y>0)
            {
                Console.WriteLine("this is forth quadrent");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}
