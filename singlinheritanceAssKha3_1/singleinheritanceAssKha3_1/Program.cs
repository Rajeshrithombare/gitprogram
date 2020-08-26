using System;

namespace AssKha3_1
{
    class BaseClass
    {
        public void Data()
        {
            Console.WriteLine("This is Parent class");
        }
    }
    class ChildClass:BaseClass
    {
        public void Data2()
        {
            Console.WriteLine("this is child class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.Data();

            ChildClass cc = new ChildClass();
            cc.Data2();

            cc.Data();
        }
    }
}
