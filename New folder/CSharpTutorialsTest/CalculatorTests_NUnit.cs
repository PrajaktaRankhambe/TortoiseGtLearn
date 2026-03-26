using NUnit.Framework;
using CSharpTutorials;

namespace CSharpTutorialsTest
{

    [TestFixture]
    public class CalculatorTests_NUnit
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSums()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSums()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(-2, -3);
            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Add_PositiveNegativeNumbers_ReturnsCorrectSums()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(-2, 3);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Add_WithZero_ReturnsSameNumber()
        {
            var calculator = new Calculator();
            int result = calculator.Add(0, 5);
            Assert.That(result, Is.EqualTo(5));
        }


        [Test]
        public void Substract_TwoPositiveNumbers_ReturnsCorrectSubstraction()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sub(30, 3);
            Assert.That(result, Is.EqualTo(27));

        }

        [Test]
        public void Substract_TwoNegativeNumbers_ReturnsCorrectSubstraction()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sub(-30, -3);
            Assert.That(result, Is.EqualTo(-27));

        }

        [Test]
        public void Substract_PositiveNegativeNumbers_ReturnsCorrectSubstraction()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sub(-30, 3);
            Assert.That(result, Is.EqualTo(-33));

        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsCorrectMultiplication()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Mul(30, 3);
            Assert.That(result, Is.EqualTo(90));

        }
        [Test]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Div(30, 3);
            Assert.That(result, Is.EqualTo(10));

        }

        [Test]
        public void Divide_NegativeNumbers_ReturnsCorrectQuotient()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Div(-30, -3);
            Assert.That(result, Is.EqualTo(10));

        }

        [Test]
        public void Calculator_Division_ForDivideByZeroExcpetionTest()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Div(30, 0));
        }
    }
}
