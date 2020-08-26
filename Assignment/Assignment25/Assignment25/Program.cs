using System;

namespace Assignment25
{
    class Program
    {
        static void Main(string[] args)
        {
            //wap accept two item weight nd number of purches and calculate the avrage value of item
            double we1, it1, we2, it2, res;
            Console.WriteLine("Enter the weight1");
            we1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the item1");
            it1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the weight1");
            we2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the item2");
            it2 = Convert.ToDouble(Console.ReadLine());
            res = (it1 + it2) / 2;
            Console.WriteLine("result is: " + res);
        }
    }
}
