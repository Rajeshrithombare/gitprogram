using System;

namespace ConstructOverloading
{
    public class Employee
    {
        public int salory;

        public Employee(int anualsalory)
        {
            salory = anualsalory;
        }
        public Employee(int weelysalory,int numberofweek)
        {
            salory = weelysalory * numberofweek;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(5000);
            Console.WriteLine("annualsalory" + e.salory);

            Employee ee = new Employee(700, 4);
            Console.WriteLine("monthSalory" + ee.salory);

            Console.ReadKey();
        }
    }
}
