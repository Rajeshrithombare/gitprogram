using System;

namespace EmployeeArrayofObject
{
    class Employee
    {
        public string Name { get; set;}
        public int YrOfJoin { get; set;}
        public string Address { get; set;}

        public void Display()
        {
            Console.Write("Name of Employee   ");
            Console.Write("Employee Year of Joining   ");
            Console.Write("Employee Address   ");
            Console.Write("                    \n"+Name);
            Console.Write("                      "+YrOfJoin);
            Console.Write("                   "+Address);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee[] em = new Employee[3];

            for(int i=0;i<3;i++)
            {
                em[i] = new Employee();

                Console.WriteLine("\nEnter the Name of Employee");
                 em[i].Name = Console.ReadLine();

                Console.WriteLine("Enter the Year Of Joining");
                em[i].YrOfJoin = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Address of Employee");
                em[i].Address = Console.ReadLine();

                em[i].Display();
            }
        
            Console.ReadKey();

           
        }
    }
}
