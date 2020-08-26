using System;

namespace singlelinestatement
{
    public class location
    {
        private String locationname;//menber variable
       
        public location(string name) => locationname = name;//constructor

        public string name
        {
            get => locationname;
            set => locationname = value;
        }
        public void showdata()
        {
            Console.WriteLine("name is= " + locationname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            location l = new location("ravi");
            Console.WriteLine("Enter Name");
            l.name=Console.ReadLine();
            l.showdata();
            Console.ReadKey();
        }
    }
}
