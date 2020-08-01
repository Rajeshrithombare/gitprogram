using System;

namespace AccassModifier
{
    class BaseClass
    {
        protected int Roll_N;

    }
    class ChildClass : BaseClass
    {
        public void GetData(int rno)
        {
            Roll_N = rno;
        }
        public void ShowData()
        {
            Console.WriteLine(Roll_N);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
            cc.GetData(44);
            cc.ShowData();
            Console.ReadKey();
        }
    }
}
