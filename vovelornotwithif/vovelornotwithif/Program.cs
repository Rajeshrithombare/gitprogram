using System;

namespace vovelornotwithif
{
    class Program
    {

        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the Character");
            ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a'|| ch=='e'|| ch=='i'|| ch=='o'|| ch=='u')
            {
                Console.WriteLine("Character is vovel");
            }
            else
            {
                Console.WriteLine("Character is not  vovel");
            }
            Console.ReadLine();
        }
    }
}
