using System;

namespace AssignRosh25_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int empid;
            int month = 26;
            int hr=200;
            int total;
            int sal;
                  Console.WriteLine("Emmploye id is");
                  empid = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("How many hours you work");
                  hr = Convert.ToInt32(Console.ReadLine());
                            total = month * 8;
                            sal = total*hr;
                   Console.WriteLine("Sallory is =" + sal);
                   Console.WriteLine("employ id is =" + empid);
                                                                                                                     
                  Console.ReadKey();

        }
    }
}
