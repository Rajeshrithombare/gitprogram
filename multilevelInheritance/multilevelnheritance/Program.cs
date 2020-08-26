using System;

namespace NewInheritance
{
    public class Person
    {
        public String EmpName { get; set;}
        public String EmpAddress { get; set;}
    }
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeDesignation { get; set; }
        public double EmployeeSalory { get; set; }

        public void GetEmployeeDetail(int empnumber, string empname, string empaddress, double empsalory, string empdesignation)
        {
            EmpName = empname;
            EmpAddress = empaddress;
            EmployeeNumber = empnumber;
            EmployeeDesignation = empdesignation;
            EmployeeSalory = empsalory;

        }
        public void ShowEmployeeData()
        {
            Console.WriteLine("Employee Detail are");
            Console.WriteLine("Employee Number is:= " + EmployeeNumber);
            Console.WriteLine("Employee Name is:= " + EmpName);
            Console.WriteLine("Employee Address is:= " + EmpAddress);
            Console.WriteLine("Employee Designation is:= " + EmployeeDesignation);
            Console.WriteLine("Employee Salory is:= " + EmployeeSalory);
        }
    }
       class PartTimeEmployee:Employee
        {
            public int NoOfHrs { get; set; }

            public void GetEmployeeDetail1(int noofhors,int empnumber, string empname, string empaddress, double empsalory, string empdesignation)
            {
                NoOfHrs = noofhors;
                EmpName = empname;
                EmpAddress = empaddress;
                EmployeeNumber = empnumber;
                EmployeeDesignation = empdesignation;
                EmployeeSalory = empsalory;

            }
            public void ShowEmployeeData1()
            {
                Console.WriteLine("Employee Detail are");
                Console.WriteLine("Employee Number of Hors is:= " + NoOfHrs);
                Console.WriteLine("Employee Number is:= " + EmployeeNumber);
                Console.WriteLine("Employee Name is:= " + EmpName);
                Console.WriteLine("Employee Address is:= " + EmpAddress);
                Console.WriteLine("Employee Designation is:= " + EmployeeDesignation);
                Console.WriteLine("Employee Salory is:= " + EmployeeSalory);
            }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.GetEmployeeDetail(123, "Raju", "Nagpur",5000, "manager");
            obj.ShowEmployeeData();
            PartTimeEmployee obj2 = new PartTimeEmployee();
            obj2.GetEmployeeDetail1(5,123, "Raju", "Nagpur", 5000, "manager");
            obj2.ShowEmployeeData1();
            Console.ReadKey();


        }
    }
}
