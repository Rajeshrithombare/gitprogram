using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClassLibrary
{
    public class Calculator
    {
        public int Addition(int a, int b)
        {
            int res = a + b;
            return res;
        }
        public int Substraction(int a, int b)
        {
            int res = a - b;
            return res;
        }
    }
}
