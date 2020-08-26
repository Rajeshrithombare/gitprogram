using System;

namespace Vovelornotwithswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the Character");
            ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Character is vovel");
                    break;
                case 'e':
                    Console.WriteLine("Character is vovel");
                    break;
                case 'i':
                    Console.WriteLine("Character is vovel");
                    break;
                case 'o':
                    Console.WriteLine("Character is vovel");
                    break;
                case 'u':
                    Console.WriteLine("Character is vovel");
                    break;
                default:
                    Console.WriteLine("Character is not vovel");
                    break;
            }
            Console.ReadKey();
        }
    }
}
