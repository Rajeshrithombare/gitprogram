using System;

namespace Staticconstructor
{
    public class Adult
    {
        private static int minimunage;//member variable with private and static
        static Adult()
        {
            minimunage = 18;
        }
        public void showdata()
        {
            Console.WriteLine("age=" + minimunage);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adult a = new Adult();
            a.showdata();
            Console.ReadKey();

        }
    }
}
