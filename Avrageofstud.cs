using System;

namespace Assiarrayob2
{//ArrayofObjeAssi2
  public  class Student
    {
        public int Roll_No { get; set;}
        public float Avrage { get; set;}
        public int subject1 { get; set;}
        public int subject2 { get; set;}
        public int subject3 { get; set;}
        public int Add { get; set; }


        public void AvrageofStude()
        {
            Add = subject1 + subject2 + subject3;
            Avrage = Add / 3;

            Console.WriteLine("Roll numberv of student is" + Roll_No);
            Console.WriteLine("Avrage Marks of Three subject is" + Avrage);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[8];
            for(int i=0;i<8;i++)
            {
                st[i] = new Student();
                Console.WriteLine("Enter Student Roll Number");
                st[i].Roll_No = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Subject one Marks");
                st[i].subject1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Subject two Marks");
                st[i].subject2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Subject three Marks");
                st[i].subject3 = int.Parse(Console.ReadLine());
                st[i].AvrageofStude();
            }
            Console.ReadKey();
            
        }
    }
}
