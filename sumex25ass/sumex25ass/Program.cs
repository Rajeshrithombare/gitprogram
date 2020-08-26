using System;

namespace sumex25ass
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            //int num;

            Console.WriteLine("Enter number");
            //num = int.Parse(Console.ReadLine());
            ob.mymethod();

            Console.ReadKey();
        }
        public void mymethod()
        {
            int n;

            n = int.Parse(Console.ReadLine());

            int n1, n2, n3, n4;
            int sum = 0;

                    n1 = n % 10;
                    n = n / 10;
                    n2 = n % 10;
                    n  = n / 10;
                    n3 = n % 10;
                    n = n / 10;
                    n4 = n % 10;
                    n = n / 10;

            sum = n1 + n2 + n3 + n4;
            Console.WriteLine(sum);

        }
    }
}
