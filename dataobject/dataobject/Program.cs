using System;

namespace dataobject
{
    public class Employee
    {
        public int eno;
        public string ename;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();

            Console.WriteLine("Enter Enumber and Employee Name");

            e.eno = int.Parse(Console.ReadLine());
            e.ename = Console.ReadLine();

            Console.WriteLine("eno=" + e.eno);
            Console.WriteLine("ename=" + e.ename);


            Console.ReadKey();

        }
    }
}
