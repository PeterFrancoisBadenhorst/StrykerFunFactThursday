using FluentAssertions;
using NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Code;

namespace ConsoleApp1.__Tests__
{
    internal class GeneralTests
    {
        private readonly GeneralClass scriptRef = new();
        [TestCase(1, 0, 1)]
        [TestCase(3, 7, 10)]
        public void TestAddTwoNumbers(int a, int b, int expected)
        {
            int actual = scriptRef.AddTwoNumbers(a, b);
            actual.Should().Be(expected);
        }
        [TestCase(1, 0, 1)]
        [TestCase(3, 7, -4)]
        public void TestSubtractTwoNumbers(int a, int b, int expected)
        {
            int actual = scriptRef.SubtractTwoNumbers(a, b);
            actual.Should().Be(expected);
        }
        [TestCase(1, 1, 1)]
        [TestCase(3, 7, 21)]
        public void TestMultiplyTwoNumbers(int a, int b, int expected)
        {
            int actual = scriptRef.MultiplyTwoNumbers(a, b);
            actual.Should().Be(expected);
        }
        [Test]
        public void TesDevideTwoNumbersException()
        {
            Action act = () => scriptRef.DevideTwoNumbers(10, 0);
            act.Should().Throw<DivideByZeroException>();
        }
        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 1)]
        public void TestDevideTwoNumbers(int a, int b, int expected)
        {
            int? actual = scriptRef.DevideTwoNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }      
    }
}
