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
        [TestCase(1, 0, -1)]
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
        public void TesDevideTwoNumbers_TypeAException(int a, int b, int expected)
        {
            Action act = () => scriptRef.DevideTwoNumbers_TypeA(10, 0);
            act.Should().Throw<DivideByZeroException>();
        }
        [TestCase(1, 1, 1)]
        [TestCase(3, 7, 21)]
        public void TestDevideTwoNumbers_TypeA(int a, int b, int expected)
        {
            int? actual = scriptRef.DevideTwoNumbers_TypeA(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TesDevideTwoNumbers_TypeBException(int a, int b, int expected)
        {
            Action act = () => scriptRef.DevideTwoNumbers_TypeB(10, 0);
            act.Should().Throw<DivideByZeroException>();
        }
        [TestCase(1, 1, 1)]
        [TestCase(3, 7, 21)]
        public void TestDevideTwoNumbers_TypeB(int a, int b, int expected)
        {
            int? actual = scriptRef.DevideTwoNumbers_TypeB(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
