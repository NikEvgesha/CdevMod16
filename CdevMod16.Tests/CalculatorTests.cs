using CdevMod16;
using NUnit.Framework;
namespace CdevMod16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculatorTest;
        [SetUp]
        public void Setup()
        {
            calculatorTest = new Calculator();
        }

        [Test]
        public void Addition_ReturnsCorrectValue()
        {
            Assert.That(calculatorTest.Addition(10, 220), Is.EqualTo(230));
        }
        [Test]
        public void Addition_MustThrowOverflowException()
        {
            Assert.Throws<OverflowException>(() => calculatorTest.Addition(2147483647, 2));
        }

        [Test]
        public void Subtraction_ReturnsCorrectValue()
        {
            Assert.That(calculatorTest.Subtraction(50, 20), Is.EqualTo(30));
        }
        [Test]
        public void Subtraction_MustThrowOverflowException()
        {
            Assert.Throws<OverflowException>(() => calculatorTest.Subtraction(-2147483647, 2));
        }

        [Test]
        public void Multiplication_ReturnsCorrectValue()
        {
            Assert.That(calculatorTest.Multiplication(25, 4), Is.EqualTo(100));
        }
        [Test]
        public void Multiplication_MustThrowOverflowException()
        {
            Assert.Throws<OverflowException>(() => calculatorTest.Multiplication(2147483647, 2));
        }


        [Test]
        public void Division_ReturnsCorrectValue() 
        {
            Assert.That(calculatorTest.Division(99, 3), Is.EqualTo(33));
        }

        [Test]
        public void Division_MustThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => calculatorTest.Division(5, 0));
        }

    }
}

