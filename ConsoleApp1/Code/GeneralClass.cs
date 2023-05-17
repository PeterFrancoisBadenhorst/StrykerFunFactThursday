﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Code
{
    [TestFixture]
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
        public int? DevideTwoNumbers_TypeA(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);

            }
            return null;
        }
        public int DevideTwoNumbers_TypeB(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();

            return a / b;
        }
    }
}
