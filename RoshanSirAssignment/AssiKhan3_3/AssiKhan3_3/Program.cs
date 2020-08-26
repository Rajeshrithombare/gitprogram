using System;

namespace AssiKhan3_3
{
    class Members
    {
        public string Name{get;set;}
        public int Age { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public int Salory { get; set; }

        public void PrintSalory(string name, int age,string phoneno,string  address,int salory)
        {
            Name = name;
            Age = age;
            PhoneNo = phoneno;
            Address = address;
            Salory = salory;
            Console.WriteLine("print Name" + Name);
            Console.WriteLine("print Age" + Age);
            Console.WriteLine("print Phone number" + PhoneNo);
            Console.WriteLine("print Address" + Address);
            Console.WriteLine("print salory" + Salory);
        }
     
    }
    class Employee : Members
    {
        public string Specialize { get; set; }
        public string Department { get; set; }


    }
    class Manager : Members
    {
        public string Specialize { get; set; }
        public string Department { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string nm, add, pho;
            int ag, sal;

            Console.WriteLine("Enter the Name of user");
            nm = Console.ReadLine();

            Console.WriteLine("Enter the Address of user");
            add = Console.ReadLine();

            Console.WriteLine("Enter the Phonenumber of user");
            pho = Console.ReadLine();

            Console.WriteLine("Enter the Age of user");
            ag = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Salory of user");
            sal = int.Parse(Console.ReadLine());

           
            Employee em = new Employee();
            em.PrintSalory(nm,ag,pho,add,sal);
            
            Manager mn = new Manager();
            //mn.PrintSalory(nm, ag, pho, add, sal);
            Console.ReadKey();
        }
    }
}
