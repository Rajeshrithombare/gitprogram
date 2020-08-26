using System;

namespace Assi16
    //Abstract1
{
    abstract class Parent
    {
        public void Message()
        {

        }
        
    }
   public class Child1
    {
        public void Message()
        {
            Console.WriteLine("this is first subclass");
        }
    }
    public class Child2
    {
        public void Message()
        {
            Console.WriteLine("this is Second subclass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child1 c = new Child1();
            c.Message();
            Child2 cc = new Child2();
            cc.Message();
            Console.ReadKey();
        }
    }
}
