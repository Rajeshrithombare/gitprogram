using System;

namespace usingThis
{
    class Bank
    {
        private string name;

        public void sename(string name)
        {
            this.name = name;
        }
        public void showdata()
        {
            Console.WriteLine(name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.sename("ravi");
            b.showdata();
            Console.ReadKey();
        }
    }
}
