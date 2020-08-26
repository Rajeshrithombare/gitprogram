using System;

namespace Structuretype
{
    struct Employee
    {
        public string firstname;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee CompanyEmployee;

            Console.WriteLine("Enter the name and age");
            CompanyEmployee.firstname = Console.ReadLine();

            CompanyEmployee.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FirstName= " + CompanyEmployee.firstname);
            Console.WriteLine("age= " + CompanyEmployee.age);


            Console.ReadKey();

       
        }
    }
}
