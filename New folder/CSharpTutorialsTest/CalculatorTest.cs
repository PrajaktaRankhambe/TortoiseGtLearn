using System;
using System.Collections.Generic;
using System.Text;
using CSharpTutorials;

namespace CSharpTutorialsTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void SubstractNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sub(30, 3);
            Assert.AreEqual(27, result);

        }
        [TestMethod]
        public void MultipleNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Mul(30, 3);
            Assert.AreEqual(90, result);

        }
        [TestMethod]
        public void DivisionNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Div(30, 0);
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void Calculator_Division_ForDivideByZeroExcpetionTest()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Div(30, 0));
        }
    }
}
