using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestingTestverktygLektion7
{
    public class Calculator
    {
        public List<int> Fibonacci = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21 };

        public void RandomFunction()
        {
            Add(1,4);
        }

        public int Add(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }
        public double Add(double value1, double value2)
        {
            double result = value1 + value2;
            return result;
        }
    }
}
