using System;

namespace AssiRosh26_4
{
    class Program
    {
        //number multiple or not
        static void Main(string[] args)
        {
            int n1, n2, temp = 0;

            Console.WriteLine("Enter number one");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number one");
            n2 = int.Parse(Console.ReadLine());
            
            if(n1/n2==0)
            {
                Console.WriteLine("multiplayid");
            }
            else if(n1/n2!=0)
            {
                Console.WriteLine("Not multiplayid");
            }
            temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("Swap num= " +n1);
            Console.WriteLine("Swap num= " + n2);

            if (n1 / n2 == 0)
            {
                Console.WriteLine("multiplayid");
            }
            else if (n1 / n2 != 0)
            {
                Console.WriteLine("Not multiplayid");
            }
            Console.ReadKey();

        }
    }
}
