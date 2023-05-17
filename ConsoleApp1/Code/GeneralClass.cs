using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Code
{
    public class GeneralClass
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
        public int SubtractTwoNumbers(int a, int b)
        {
            return a - b;
        }
        public int MultiplyTwoNumbers(int a, int b)
        {
            return a * b;
        }
        
        public int DevideTwoNumbers(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();

            return a / b;
        }
    }
}
