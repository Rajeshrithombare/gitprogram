using System;

namespace AssiKha3_2
{
    class ParentClass
    {
         private void Data()
        {
            Console.WriteLine("parent");
        }
    }
    class ChildClass
    {
        private void Data1()
        {
            Console.WriteLine("child");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass pc = new ParentClass();
            pc.Data();
            ChildClass cc = new ChildClass();
            cc.Data1();
            cc.Data();
            Console.ReadKey();
        }
    }
}
