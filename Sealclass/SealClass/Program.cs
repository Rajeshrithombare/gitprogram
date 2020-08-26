using System;

namespace SealClass
{
    interface IToken
    {
        string Name();
    }
   interface IVissibal
    {
       void Name();
    }

    class Token:IToken,IVissibal
    {
        string IToken.Name()
        {
            return "hello from Name";
        }
        void IVissibal.Name()
        {
            Console.WriteLine("");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IToken t = new Token();
            Console.WriteLine(t.Name());
            IVissibal t1 = new Token();
            t1.Name();

            Console.ReadKey();
        }
    }
}
